using SearchService.Domain;
using Zack.EventBus;

namespace SearchService.WebAPI.EventHandlers
{
    [EventName("ListeningEpisode.Deleted")]
    [EventName("ListeningEpisode.Hidden")]//被隐藏也看作删除
    public class ListeningEpisodeDeletedEventHandler : DynamicIntegrationEventHandler
    {
        private readonly ISearchRepository _repository;
        public ListeningEpisodeDeletedEventHandler(ISearchRepository repository)
        {
            _repository = repository;
        }
        public override Task HandleDynamic(string eventName, dynamic eventData)
        {
            Guid id = Guid.Parse(eventData.Id);
            return _repository.DeleteAsync(id);
        }
    }
}
