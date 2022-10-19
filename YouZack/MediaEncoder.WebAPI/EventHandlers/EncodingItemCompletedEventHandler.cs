using MediaEncoder.Domain.Events;
using MediatR;
using Zack.EventBus;

namespace MediaEncoder.WebAPI.EventHandlers
{
    public class EncodingItemCompletedEventHandler:INotificationHandler<EncodingItemCompletedEvent>
    {
        private readonly IEventBus _eventBus;
        public EncodingItemCompletedEventHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }
        public Task Handle(EncodingItemCompletedEvent notification, CancellationToken cancellationToken)
        {
            _eventBus.Publish("MediaEncoding.Completed", cancellationToken);
            return Task.CompletedTask;
        }
    }
}
