using Zack.EventBus;

namespace WebApplicationRabbitMQConsumer
{
    [EventName("OrderCreated")]//监听名字为OrderCreated的消息
    public class EventHandler3:DynamicIntegrationEventHandler
    {
        public override Task HandleDynamic(string eventName, dynamic eventData)
        {
            Console.WriteLine($"EventHandler3,收到了订单，{eventData.Id},{eventData.Name},{eventData.Date}");
            return Task.CompletedTask;
        }
    }
}
