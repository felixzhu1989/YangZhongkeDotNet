using FileService.Domain;
using FileService.Domain.Entities;

namespace FileService.Infrastructure
{
    public class FSRepository:IFSRepository
    {
        private readonly FSDbContext _dbContext;
        public FSRepository(FSDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<UploadedItem?> FindFileAsync(long fileSize, string sha256Hash)
        {
            return _dbContext.UploadedItems.FirstOrDefaultAsync(u =>
                u.FileSizeInBytes == fileSize && u.FileSHA256Hash == sha256Hash);
        }
    }
}
