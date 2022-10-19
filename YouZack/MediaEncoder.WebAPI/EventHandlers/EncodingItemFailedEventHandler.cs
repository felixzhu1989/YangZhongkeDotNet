using MediaEncoder.Domain.Events;
using MediatR;
using Zack.EventBus;

namespace MediaEncoder.WebAPI.EventHandlers
{
    public class EncodingItemFailedEventHandler:INotificationHandler<EncodingItemFailedEvent>
    {
        private readonly IEventBus _eventBus;
        public EncodingItemFailedEventHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }
        public Task Handle(EncodingItemFailedEvent notification, CancellationToken cancellationToken)
        {
            _eventBus.Publish("MediaEncoding.Failed", cancellationToken);
            return Task.CompletedTask;
        }
    }
}
