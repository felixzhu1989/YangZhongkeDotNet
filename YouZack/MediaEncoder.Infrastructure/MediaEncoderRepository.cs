using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaEncoder.Domain;
using MediaEncoder.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MediaEncoder.Infrastructure
{
    public class MediaEncoderRepository:IMediaEncoderRepository 
    {
        private readonly MEDbContext _context;
        public MediaEncoderRepository(MEDbContext context)
        {
            _context = context;
        }
        public Task<EncodingItem?> FindCompletedOneAsync(string fileHash, long fileSize)
        {
            return _context.EncodingItems.FirstOrDefaultAsync(x=>x.FileSHA256Hash==fileHash&&x.FileSizeInBytes==fileSize&&x.Status==ItemStatus.Completed);
        }
        public Task<EncodingItem[]> FindAsync(ItemStatus status)
        {
            return _context.EncodingItems.Where(x => x.Status == status).ToArrayAsync();
        }
    }
}
