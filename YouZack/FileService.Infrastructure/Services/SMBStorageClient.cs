using FileService.Domain;
using Microsoft.Extensions.Options;

namespace FileService.Infrastructure.Services
{
    /// <summary>
    /// 用【局域网内共享文件夹】或者【本机磁盘】当备份服务器的实现类
    /// </summary>
    public class SMBStorageClient : IStorageClient
    {
        public StorageType StorageType => StorageType.Backup;
        private readonly IOptionsSnapshot<SMBStorageOptions> _options;
        public SMBStorageClient(IOptionsSnapshot<SMBStorageOptions> options)
        {
            _options = options;
        }

        public async Task<Uri> SaveAsync(string key, Stream content, CancellationToken cancellationToken = default)
        {
            if (key.StartsWith('/'))
            {
                throw new ArgumentException("key should not start with /", nameof(key));
            }
            string workingDir = _options.Value.WorkingDir;
            string fullPath = Path.Combine(workingDir, key);
            string? fullDir = Path.GetDirectoryName(fullPath);
            if (!Directory.Exists(fullDir)) Directory.CreateDirectory(fullDir);
            if (File.Exists(fullPath)) File.Delete(fullPath);
            await using Stream outStream = File.OpenWrite(fullPath);
            content.Position=0;//复位流读取的位置，因为上面已经读取过流了，为了下一次再读取流，应当复位流的指针
            await content.CopyToAsync(outStream, cancellationToken);
            return new Uri(fullPath);
        }
    }
}
