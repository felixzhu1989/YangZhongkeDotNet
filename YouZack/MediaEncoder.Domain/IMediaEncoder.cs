namespace MediaEncoder.Domain
{
    public interface IMediaEncoder
    {
        /// <summary>
        /// 是否能处理目标为outputFormat类型的文件
        /// </summary>
        bool Accept(string outputFormat);
        /// <summary>
        /// 进行转换
        /// </summary>
        Task EncodeAsync(FileInfo sourceFile, FileInfo destFile, string destFormat, string[]? args,
            CancellationToken ct);
    }
}
