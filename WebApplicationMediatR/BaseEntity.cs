using MediatR;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationMediatR
{
    public abstract class BaseEntity:IDomainEvents
    {
        [NotMapped] //相当与FluentAPI中的Ignore
        private IList<INotification> events=new List<INotification>();
        public IEnumerable<INotification> GetDomainEvents()
        {
           return events;
        }

        public void AddDomainEvent(INotification eventItem)
        {
            events.Add(eventItem);
        }

        public void AddDomainEventAbsent(INotification eventItem)
        {
            //暂时不实现
        }

        public void ClearDomainEvent()
        {
            events.Clear();
        }
    }
}
