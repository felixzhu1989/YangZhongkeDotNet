using Zack.EventBus;

namespace WebApplicationRabbitMQConsumer
{
    [EventName("OrderCreated")]//监听名字为OrderCreated的消息
    [EventName("OrderDeleted")]//可以监听多个消息
    public class EventHandler1:IIntegrationEventHandler
    {
        public Task Handle(string eventName, string eventData)
        {
            if (eventName == "OrderCreated")
            {
                //eventData为json序列化后的字符串
                Console.WriteLine($"EventHandler1,收到了订单，eventData={eventData}");
            }
            return Task.CompletedTask;
        }
    }
}
