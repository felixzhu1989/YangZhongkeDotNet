using MediatR;

namespace WebApplicationMediatR
{
    public interface IDomainEvents
    {
        IEnumerable<INotification> GetDomainEvents();//获得所有注册了的事件
        void AddDomainEvent(INotification eventItem);//注册要发布的消息
        void AddDomainEventAbsent(INotification eventItem);//如果消息存在就不重复注册
        void ClearDomainEvent();//清除注册的消息
    }
}
