using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileService.Domain.Entities;

namespace FileService.Domain
{
    /// <summary>
    /// 仓储接口
    /// </summary>
    public interface IFSRepository
    {
        /// <summary>
        /// 查找已经上传的相同大小以及散列值的文件记录（从数据库中查找记录）
        /// </summary>
        /// <param name="fileSize">文件大小</param>
        /// <param name="sha256Hash">散列值</param>
        /// <returns></returns>
        Task<UploadedItem?> FindFileAsync(long fileSize, string sha256Hash);
    }
}
