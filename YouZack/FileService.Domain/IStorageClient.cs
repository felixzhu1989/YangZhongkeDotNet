namespace FileService.Domain
{
    /// <summary>
    /// 文件存储防腐层接口
    /// </summary>
    public interface IStorageClient
    {
        StorageType StorageType { get; }//增加一个属性，表明当前是云存储还是备份服务器
        /// <summary>
        /// 保存文件
        /// </summary>
        /// <param name="key">文件的key（一般是文件路径的一部分）</param>
        /// <param name="content">文件内容，文件流</param>
        /// <param name="cancellationToken"></param>
        /// <returns>存储返回的可以被访问的文件Url</returns>
        Task<Uri> SaveAsync(string key, Stream content, CancellationToken cancellationToken = default);
    }
}
