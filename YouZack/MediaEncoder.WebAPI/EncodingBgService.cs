using System.Net;
using FileService.SDK.NETCore;
using MediaEncoder.Domain;
using MediaEncoder.Domain.Entities;
using MediaEncoder.Infrastructure;
using Microsoft.Extensions.Options;
using RedLockNet.SERedis;
using RedLockNet.SERedis.Configuration;
using StackExchange.Redis;
using Zack.Commons;
using Zack.EventBus;
using Zack.JWT;

namespace MediaEncoder.WebAPI
{
    public class EncodingBgService : BackgroundService
    {
        private readonly IServiceScope _serviceScope;
        private readonly IMediaEncoderRepository _repository;
        private readonly MEDbContext _context;
        private readonly List<RedLockMultiplexer> _redLockMultiplexerList;
        private readonly ILogger<EncodingBgService> _logger;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly MediaEncoderFactory _encoderFactory;
        private readonly IOptionsSnapshot<FileServiceOptions> _optionFileService;
        private readonly IEventBus _eventBus;
        private readonly IOptionsSnapshot<JWTOptions> _optionJwt;
        private readonly ITokenService _tokenService;

        public EncodingBgService(IServiceScopeFactory spf)
        {
            //MEDbContext等是Scoped，而BackgroundService是Singleton，
            //所以不能直接注入，需要手动开启一个新的Scope
            _serviceScope = spf.CreateScope();
            var sp = _serviceScope.ServiceProvider;
            _repository = sp.GetRequiredService<IMediaEncoderRepository>();
            _context = sp.GetRequiredService<MEDbContext>();
            //生产环境中，RedLock需要五台服务器才能体现价值，测试环境无所谓
            IConnectionMultiplexer connectionMultiplexer = sp.GetRequiredService<IConnectionMultiplexer>();
            _redLockMultiplexerList=new List<RedLockMultiplexer> { new(connectionMultiplexer) };
            _logger = sp.GetRequiredService<ILogger<EncodingBgService>>();
            _httpClientFactory = sp.GetRequiredService<IHttpClientFactory>();
            _encoderFactory = sp.GetRequiredService<MediaEncoderFactory>();
            _optionFileService = sp.GetRequiredService<IOptionsSnapshot<FileServiceOptions>>();
            _eventBus = sp.GetRequiredService<IEventBus>();
            _optionJwt = sp.GetRequiredService<IOptionsSnapshot<JWTOptions>>();
            _tokenService = sp.GetRequiredService<ITokenService>();
        }

        /// <summary>
        /// 下载原视频
        /// </summary>
        /// <returns>ok表示是否下载成功，sourceFile为保存成功的本地文件</returns>
        private async Task<(bool ok, FileInfo sourceFile)> DownloadSrcAsync(EncodingItem encItem, CancellationToken ct)
        {
            //开始下载源文件
            string tempDir = Path.Combine(Path.GetTempPath(), "MediaEncodingDir");
            //源文件的临时保存路径，用guid做为文件名，拼接上后缀
            string sourceFullPath = Path.Combine(tempDir, $"{Guid.NewGuid()}.{Path.GetExtension(encItem.Name)}");
            FileInfo sourceFile = new FileInfo(sourceFullPath);
            Guid id = encItem.Id;
            sourceFile.Directory!.Create();//创建可能不存在的文件夹
            _logger.LogInterpolatedInformation($"Id={id}，准备从{encItem.SourceUrl}下载到{sourceFullPath}");
            HttpClient httpClient = _httpClientFactory.CreateClient();
            var statusCode = await httpClient.DownloadFileAsync(encItem.SourceUrl, sourceFullPath, ct);
            if (statusCode != HttpStatusCode.OK)
            {
                _logger.LogInterpolatedWarning($"下载Id={id}，Url={encItem.SourceUrl}失败，{statusCode}");
                sourceFile.Delete();
                return (false, sourceFile);
            }
            return (false, sourceFile);
        }
        /// <summary>
        /// 把file上传到云存储服务器
        /// </summary>
        /// <returns>保存后的远程文件的路径</returns>
        private Task<Uri?> UploadFileAsync(FileInfo file, CancellationToken ct)
        {
            Uri urlRoot = _optionFileService.Value.UrlRoot;
            //FileService.SDK.NETCore
            FileServiceClient fileService =
                new FileServiceClient(_httpClientFactory, urlRoot, _optionJwt.Value, _tokenService);
            return fileService.UploadAsync(file, ct);
        }
        /// <summary>
        /// 构建转码后的目标文件
        /// </summary>
        private static FileInfo BuildDestFileInfo(EncodingItem encItem)
        {
            string outputFormat = encItem.OutputFormat;
            string tempDir = Path.GetTempPath();
            string destFullPath = Path.Combine(tempDir, $"{Guid.NewGuid()}.{outputFormat}");
            return new FileInfo(destFullPath);
        }
        /// <summary>
        /// 计算文件的散列值
        /// </summary>
        private static string ComputeSha256Hash(FileInfo file)
        {
            using FileStream streamSrc = file.OpenRead();
            return HashHelper.ComputeSha256Hash(streamSrc);
        }

        /// <summary>
        /// 对srcFile按照outputFormat格式转码，保存到outputFormat
        /// </summary>
        /// <returns>转码结果</returns>
        private async Task<bool> EncodeAsync(FileInfo srcFile, FileInfo destFile,
            string outputFormat, CancellationToken ct)
        {
            var encoder = _encoderFactory.Create(outputFormat);
            if (encoder == null)
            {
                _logger.LogInterpolatedError($"转码失败，找不到转码器，目标格式:{outputFormat}");
                return false;
            }
            try
            {
                await encoder.EncodeAsync(srcFile, destFile, outputFormat, null, ct);
            }
            catch (Exception ex)
            {
                _logger.LogInterpolatedError($"转码失败", ex);
                return false;
            }
            return true;
        }

        private async Task ProcessItemAsync(EncodingItem encItem, CancellationToken ct)
        {
            Guid id = encItem.Id;
            var expiry = TimeSpan.FromSeconds(30);
            //Redis分布式锁来避免两个转码服务器处理同一个转码任务的问题
            var redLockFactory = RedLockFactory.Create(_redLockMultiplexerList);
            string lockKey = $"MediaEncoder.EncodingItem.{id}";
            //用RedLock分布式锁，锁定对EncodingItem的访问
            await using var redLock = await redLockFactory.CreateLockAsync(lockKey, expiry);
            if (!redLock.IsAcquired)
            {
                _logger.LogInterpolatedWarning($"获取{lockKey}锁失败，已被抢走");
                //获得锁失败，锁已经被别人抢走了，说明这个任务被别的实例处理了（有可能有服务器集群来分担转码压力）
                return;//再去抢下一个
            }
            encItem.Start();
            await _context.SaveChangesAsync(ct);//立即保存一下状态的修改
            //发出一次集成事件
            var (downloadOk, srcFile) = await DownloadSrcAsync(encItem, ct);
            if (!downloadOk)
            {
                encItem.Fail($"下载失败");
                return;
            }
            FileInfo destFile = BuildDestFileInfo(encItem);
            try
            {
                _logger.LogInterpolatedInformation($"下载Id={id}成功，开始计算Hash值");
                long fileSize = srcFile.Length;
                string srcFileHash = ComputeSha256Hash(srcFile);
                //如果之前存在过和这个文件大小、hash一样的文件，就认为重复了
                var prevInstance = await _repository.FindCompletedOneAsync(srcFileHash, fileSize);
                if (prevInstance != null)
                {
                    _logger.LogInterpolatedInformation($"检查Id={id}Hash值成功，发现已经存在相同大小和Hash值的旧任务Id={prevInstance.Id}，返回！");
                    _eventBus.Publish("MediaEncoding.Duplicated", new { encItem.Id, encItem.SourceSystem, OutputUrl = prevInstance.OutputUrl });
                    encItem.Complete(prevInstance.OutputUrl!);
                    return;
                }
                //开始转码
                _logger.LogInterpolatedInformation($"Id={id}开始转码，源路径:{srcFile},目标路径:{destFile}");
                string outputFormat = encItem.OutputFormat;
                var encodingOK = await EncodeAsync(srcFile, destFile, outputFormat, ct); ;
                if (!encodingOK)
                {
                    encItem.Fail($"转码失败");
                    return;
                }
                //开始上传
                _logger.LogInterpolatedInformation($"Id={id}转码成功，开始准备上传");
                var destUrl = await UploadFileAsync(destFile, ct);
                encItem.Complete(destUrl!);
                encItem.ChangeFileMeta(fileSize, srcFileHash);
                _logger.LogInterpolatedInformation($"Id={id}转码结果上传成功");
                //发出集成事件和领域事件

            }
            finally
            {
                srcFile.Delete();
                destFile.Delete();
            }
        }


        protected override async Task ExecuteAsync(CancellationToken ct = default)
        {
            //死循环
            while (!ct.IsCancellationRequested)
            {
                //获取所有处于Ready状态的任务
                //ToListAsync()可以避免在循环中再用DbContext去查询数据
                //导致的“There is already an open DataReader associated with this Connection which must be closed first.”
                var readyItems = await _repository.FindAsync(ItemStatus.Ready);
                foreach (EncodingItem readyItem in readyItems)
                {
                    try
                    {
                        await ProcessItemAsync(readyItem, ct);//因为转码比较消耗cpu等资源，因此串行转码
                    }
                    catch (Exception ex)
                    {
                        readyItem.Fail(ex);
                    }
                    await this._context.SaveChangesAsync(ct);
                }
                await Task.Delay(5000, ct);//暂停5s，避免没有任务的时候CPU空转
            }
        }

        public override void Dispose()
        {
            base.Dispose();
            _serviceScope.Dispose();
        }
    }
}
