using Listening.Domain.Entities;
using Zack.DomainCommons.Models;

namespace Listening.Domain
{
    public class ListeningDomainService
    {
        private readonly IListeningRepository _repository;
        public ListeningDomainService(IListeningRepository repository)
        {
            _repository = repository;
        }

        public async Task<Episode> AddEpisodeAsync(Guid albumId, MultilingualString name,Uri audioUrl,double durationInSecond,string subtitleType,string subtitle)
        {
            int maxSeq = await _repository.GetMaxSeqOfEpisodesAsync(albumId);
            var id = Guid.NewGuid();
            //return Episode.Create(id, maxSeq + 1, name, albumId,audioUrl,durationInSecond, subtitleType, subtitle);
            var builder = new Episode.Builder();
            builder.Id(id).SequenceNumber(maxSeq + 1).Name(name).AlbumId(albumId)
                .AudioUrl(audioUrl).DurationInSecond(durationInSecond)
                .SubtitleType(subtitleType).Subtitle(subtitle);
            return builder.Build();
        }
        public async Task SortEpisodesAsync(Guid albumId, Guid[] sortedEpisodeIds)
        {
            var episodes = await _repository.GetEpisodesByAlbumIdAsync(albumId);
            var idsInDb = episodes.Select(a => a.Id);
            //NuGet安装：Install-Package Zack.Commons
            if (!idsInDb.SequenceIgnoredEqual(sortedEpisodeIds))
            {
                throw new Exception($"提交的待排序Id中必须是albumId={albumId}分类下所有的Id");
            }
            int seqNum = 1;
            //一个in语句一次性取出来更快，不过在非性能关键节点，业务语言比性能更重要
            foreach (var episodeId in sortedEpisodeIds)
            {
                var episode = await _repository.GetEpisodeByIdAsync(episodeId);
                if (episode == null) throw new Exception($"episodeId={episodeId}不存在");
                episode.ChangeSequenceNumber(seqNum);//顺序改序号
                seqNum++;
            }
        }

        public async Task<Album> AddAlbumAsync(Guid categoryId, MultilingualString name)
        {
            int maxSeq = await _repository.GetMaxSeqOfAlbumsAsync(categoryId);
            var id = Guid.NewGuid();
            return Album.Create(id, maxSeq + 1, name, categoryId);
        }
        public async Task SortAlbumsAsync(Guid categoryId, Guid[] sortedAlbumIds)
        {
            var albums = await _repository.GetAlbumsByCategoryIdAsync(categoryId);
            var idsInDb=albums.Select(a => a.Id);
            if (!idsInDb.SequenceIgnoredEqual(sortedAlbumIds))
            {
                throw new Exception($"提交的待排序Id中必须是categoryId={categoryId}分类下所有的Id");
            }
            int seqNum = 1;
            foreach (var albumId in sortedAlbumIds)
            {
                var album = await _repository.GetAlbumByIdAsync(albumId);
                if (album == null) throw new Exception($"albumId={albumId}不存在");
                album.ChangeSequenceNumber(seqNum);
                seqNum++;
            }
        }

        public async Task<Category> AddCategoryAsync(MultilingualString name,Uri coverUrl)
        {
            int maxSeq = await _repository.GetMaxSeqOfCategoriesAsync();
            var id = Guid.NewGuid();
            return Category.Create(id,maxSeq+1,name,coverUrl);
        }
        public async Task SortCategoriesAsync(Guid[] sortedCategoryIds)
        {
            var categories = await _repository.GetCategoriesAsync();
            var idsInDb = categories.Select(a => a.Id);
            if (!idsInDb.SequenceIgnoredEqual(sortedCategoryIds))
            {
                throw new Exception($"提交的待排序Id中必须是所有的分类Id");
            }
            int seqNum = 1;
            foreach (var categoryId in sortedCategoryIds)
            {
                var category = await _repository.GetCategoryByIdAsync(categoryId);
                if (category == null) throw new Exception($"categoryId={categoryId}不存在");
                category.ChangeSequenceNumber(seqNum);
                seqNum++;
            }
        }
    }
}
