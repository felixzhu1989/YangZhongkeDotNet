using Zack.DomainCommons.Models;

namespace FileService.Domain.Entities
{
    //NuGet安装：Install-Package Zack.DomainCommons
    //继承自BaseEntity,已经设定Guid类型的主键Id，以及其他领域事件DomainEvent相关的操作
    /// <summary>
    /// 文件上传项，每个上传的文件都对应一个上传项
    /// </summary>
    public record UploadedItem :BaseEntity, IHasCreationTime
    {
        public DateTime CreationTime { get;private set; }//继承自IHasCreationTime，上传时间

        //如果严格按照DDD来设计应该定义值类型，包含枚举Unit(KB,MB,GB)
        //这里因为方便今后比较文件大小，做了妥协，会更方便使用
        /// <summary>
        /// 文件大小（单位为字节）
        /// </summary>
        public long FileSizeInBytes { get;private set; }
        /// <summary>
        /// 用户上传的原始文件名，没有包含路径
        /// </summary>
        public string FileName { get;private set; }

        //两个文件的大小和散列值（SHA256）都相同的概率非常小。因此只要大小和SHA256相同，就认为是相同的文件。
        //SHA256的碰撞的概率比MD5低很多。不是加密算法，是单向的指纹算法
        /// <summary>
        /// 文件的SHA256散列值（非常重要的属性）
        /// </summary>
        public string FileSHA256Hash { get;private set; }

        //备份文件路径，因为可能会更换文件存储系统或者云存储供应商，因此系统会保存一份自有的路径。
        //备份文件一般放到内网的高速、稳定设备上，比如NAS等。（演示时存在本地就好了）
        /// <summary>
        /// 备份文件路径
        /// </summary>
        public Uri BackupUrl { get;private set; }

        /// <summary>
        /// 云存储路径,上传的文件的供外部访问者访问的路径（演示时存在服务器上一个路径）
        /// </summary>
        public Uri RemoteUrl { get;private set; }


        //创建类的对象实例(其实就是初始化)，因为都是只读属性
        public static UploadedItem Create(Guid id, long fileSizeInBytes, string fileName, string fileSHA256Hash,
            Uri backupUrl, Uri remoteUrl)
        {
            UploadedItem item = new UploadedItem()
            {
                Id=id,
                CreationTime = DateTime.Now,
                FileName=fileName,  
                FileSHA256Hash = fileSHA256Hash,
                FileSizeInBytes=fileSizeInBytes,
                BackupUrl = backupUrl,
                RemoteUrl=remoteUrl
            };
            return item;
        }

    }
}
