using MediaEncoder.Domain.Events;
using MediatR;
using Zack.EventBus;

namespace MediaEncoder.WebAPI.EventHandlers
{
    public class EncodingItemStartedEventHandler:INotificationHandler<EncodingItemStartedEvent>
    {
        private readonly IEventBus _eventBus;
        public EncodingItemStartedEventHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }
        public Task Handle(EncodingItemStartedEvent notification, CancellationToken cancellationToken)
        {
            //把转码任务状态变化的领域事件，转换为集成事件发出
            _eventBus.Publish("MediaEncoding.Started", cancellationToken);
            return Task.CompletedTask;
        }
    }
}
