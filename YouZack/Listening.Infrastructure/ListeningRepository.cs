using Listening.Domain;
using Listening.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Listening.Infrastructure
{
    public class ListeningRepository : IListeningRepository
    {
        private readonly ListeningDbContext _context;
        public ListeningRepository(ListeningDbContext context)
        {
            _context = context;
        }
        public async Task<Category?> GetCategoryByIdAsync(Guid categoryId)
        {
            return await _context.FindAsync<Category>(categoryId);
        }

        public Task<Category[]> GetCategoriesAsync()
        {
            return _context.Categories.OrderBy(x => x.SequenceNumber).ToArrayAsync();
        }

        public async Task<int> GetMaxSeqOfCategoriesAsync()
        {
            //当没有数据时报错
            //System.InvalidOperationException: Sequence contains no elements.
            var maxSeq = await _context.Query<Category>().MaxAsync(x => (int?)x.SequenceNumber);
            return maxSeq?? 0;
        }

        public async Task<Album?> GetAlbumByIdAsync(Guid albumId)
        {
            return await _context.FindAsync<Album>(albumId);
        }

        public Task<Album[]> GetAlbumsByCategoryIdAsync(Guid categoryId)
        {
            return _context.Albums.OrderBy(x => x.SequenceNumber).Where(x => x.CategoryId == categoryId).ToArrayAsync();
        }

        public async Task<int> GetMaxSeqOfAlbumsAsync(Guid categoryId)
        {
            var maxSeq=await _context.Query<Album>().Where(x => x.CategoryId==categoryId).MaxAsync(x => (int?)x.SequenceNumber);
            return maxSeq ?? 0;
        }

        public Task<Episode?> GetEpisodeByIdAsync(Guid episodeId)
        {
            return _context.Episodes.SingleOrDefaultAsync(x => x.Id==episodeId);
        }

        public Task<Episode[]> GetEpisodesByAlbumIdAsync(Guid albumId)
        {
            return _context.Episodes.OrderBy(x => x.SequenceNumber).Where(x => x.AlbumId==albumId).ToArrayAsync();
        }

        public async Task<int> GetMaxSeqOfEpisodesAsync(Guid albumId)
        {
            var maxSeq = await _context.Query<Episode>().Where(x => x.AlbumId==albumId).MaxAsync(x => (int?)x.SequenceNumber);
            return maxSeq ?? 0;
        }
    }
}
