using Zack.EventBus;

namespace WebApplicationRabbitMQConsumer
{
    //暂时不能收到自己发送出去的消息？
    [EventName("OrderCreated")]//监听名字为OrderCreated的消息
    public class EventHandler4:DynamicIntegrationEventHandler
    {
        public override Task HandleDynamic(string eventName, dynamic eventData)
        {
            Console.WriteLine($"EventHandler4,收到了自己发送的订单，{eventData.Id},{eventData.Name},{eventData.Date}");
            return Task.CompletedTask;
        }
    }
}
