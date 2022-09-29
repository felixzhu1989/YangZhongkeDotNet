using Listening.Domain.Entities;

namespace Listening.Domain
{
    public interface IListeningRepository
    {
        public Task<Category?> GetCategoryByIdAsync(Guid categoryId);
        public Task<Category[]> GetCategoriesAsync();
        public Task<int> GetMaxSeqOfCategoriesAsync();//获取最大序号
        public Task<Album?> GetAlbumByIdAsync(Guid albumId);
        public Task<Album[]> GetAlbumsByCategoryIdAsync(Guid categoryId);
        public Task<int> GetMaxSeqOfAlbumsAsync(Guid categoryId);
        public Task<Episode?> GetEpisodeByIdAsync(Guid episodeId);
        public Task<Episode[]> GetEpisodesByAlbumIdAsync(Guid albumId);
        public Task<int> GetMaxSeqOfEpisodesAsync(Guid albumId);
    }
}
