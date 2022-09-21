using Zack.EventBus;

namespace WebApplicationRabbitMQConsumer
{
    [EventName("OrderCreated")]//监听名字为OrderCreated的消息
    public class EventHandler2:JsonIntegrationEventHandler<OrderData>
    {
        public override Task HandleJson(string eventName, OrderData? eventData)
        {
            Console.WriteLine($"EventHandler2,收到了订单，eventData={eventData}");
            return Task.CompletedTask;
        }
    }
    public record OrderData(int Id, string Name, DateTime Date);
}
