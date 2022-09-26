using FileService.Domain.Entities;
using Zack.Commons;

namespace FileService.Domain
{
    /// <summary>
    /// 领域模型的领域服务（封装主干逻辑）
    /// </summary>
    public class FSDomainService
    {
        //注入3个实例
        private readonly IFSRepository _repository;//仓储
        private readonly IStorageClient _backupStorage;//备份服务器
        private readonly IStorageClient _remoteStorage;//文件存储服务器（云存储）

        //IEnumerable<IStorageClient> storageClients会注入所有实现了IStorageClient接口的服务
        public FSDomainService(IFSRepository repository,IEnumerable<IStorageClient> storageClients)
        {
            _repository = repository;
            //用这种方式可以解决内置DI不能使用名字注入不同实例的问题，而且从原则上来讲更加优美
            _backupStorage = storageClients.First(c=>c.StorageType==StorageType.Backup);
            _remoteStorage = storageClients.First(c=>c.StorageType==StorageType.Public);
        }
        
        /// <summary>
        /// 上传文件，领域服务只有抽象的业务逻辑(面向接口编程)，没有细节实现
        /// </summary>
        public async Task<UploadedItem> UploadAsync(Stream stream, string fileName, CancellationToken cancellationToken)
        {
            //NuGet安装：Install-Package Zack.Commons
            string hash = HashHelper.ComputeSha256Hash(stream);//计算散列值
            long fileSize = stream.Length;
            DateTime today = DateTime.Today;
            //用日期把文件分散在不同文件夹存储，同时由于加上了文件hash值作为目录，又用用户上传的文件夹做文件名，
            //所以几乎不会发生不同文件冲突的可能
            //用用户上传的文件名保存文件名，这样用户查看、下载文件的时候，文件名更灵活
            //fileName是原始文件名
            string key = $"{today.Year}/{today.Month}/{today.Day}/{hash}/{fileName}";
            //如果觉得层级太多，可以省去日，按月进行文件夹存储$"{today.Year}/{today.Month}/{hash}/{fileName}"

            //查询是否有和上传文件的大小和SHA256一样的文件，如果有的话，就认为是同一个文件
            //虽然说前端可能已经调用FileExists接口检查过了，但是前端可能跳过了，或者有并发上传等问题，所以这里再检查一遍。
            var oldUploadItem = await _repository.FindFileAsync(fileSize, hash);
            if (oldUploadItem != null) return oldUploadItem;//如果存在则直接返回旧文件

            //先保存备份，再保存到云存储
            //backupStorage实现很稳定、速度很快，一般都使用本地存储（文件共享或者NAS）
            //这里是面向接口编程，所以只是执行保存即可，至于如何保存则应在实现接口的地方编写具体保存逻辑
            //stream.Position = 0;
            Uri backupUrl = await _backupStorage.SaveAsync(key, stream, cancellationToken);//保存到本地备份
            //stream.Position = 0;
            Uri remoteUrl=await _remoteStorage.SaveAsync(key, stream, cancellationToken);//保存到生产的存储系统,云服务
            //stream.Position = 0;//复位流读取的位置，因为上面已经读取过流了，为了下一次再读取流，应当复位流的指针

            Guid id=new Guid();
            //领域服务并不会真正的执行数据库插入，只是把实体对象生成，然后由应用服务和基础设施配合来真正的插入数据库！
            //DDD中尽量避免直接在领域服务中执行数据库的修改（包含删除、新增）操作。
            return UploadedItem.Create(id,fileSize,fileName,hash,backupUrl,remoteUrl);
        }
    }
}
