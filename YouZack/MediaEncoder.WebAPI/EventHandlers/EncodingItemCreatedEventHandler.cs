using MediaEncoder.Domain.Events;
using MediatR;
using Zack.EventBus;

namespace MediaEncoder.WebAPI.EventHandlers
{
    public class EncodingItemCreatedEventHandler:INotificationHandler<EncodingItemCompletedEvent>
    {
        private readonly IEventBus _eventBus;
        public EncodingItemCreatedEventHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }
        public Task Handle(EncodingItemCompletedEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
