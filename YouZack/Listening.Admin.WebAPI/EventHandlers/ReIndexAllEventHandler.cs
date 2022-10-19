using Listening.Infrastructure;
using Zack.EventBus;

namespace Listening.Admin.WebAPI.EventHandlers
{
    [EventName("SearchService.ReIndexAll")]
    //让搜索引擎重新收入所有的Episode
    public class ReIndexAllEventHandler : IIntegrationEventHandler
    {
        private readonly ListeningDbContext _dbContext;
        private readonly IEventBus _eventBus;
        public ReIndexAllEventHandler(ListeningDbContext dbContext, IEventBus eventBus)
        {
            _dbContext = dbContext;
            _eventBus = eventBus;
        }
        public Task Handle(string eventName, string eventData)
        {
            foreach (var episode in _dbContext.Query<Episode>())
            {
                if (episode.IsVisible)
                {
                    var sentences = episode.ParseSubtitle();
                    _eventBus.Publish("ListeningEpisode.Updated",new{episode.Id,episode.Name,Sentences=sentences,episode.AlbumId,episode.Subtitle,episode.SubtitleType});
                }
            }
            return Task.CompletedTask;
        }
    }
}
