using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

var connFactory = new ConnectionFactory
{
    HostName = "127.0.0.1", //RabbitMQ服务器地址
    DispatchConsumersAsync = true
};
var connection = connFactory.CreateConnection();//创建连接
var exchangeName = "exchange1";//交换机的名字
var eventName = "myEvent";//routingKey的值
using var channel = connection.CreateModel();//创建信道
//声明交换机(交换机名，类型direct)，跟消息发送的不相关，谁先声明谁先用
channel.ExchangeDeclare(exchangeName, "direct");
var queueName = "queue1";
//声明队列，消息发送者不需要知道队列，队列是跟消费者相关的
channel.QueueDeclare(queueName, durable:true, exclusive:false,autoDelete:false,arguments:null);
//绑定队列，只要有routingKey相同的消息就加入到队列中，可以绑定多个routingKey，执行多次QueueBind
channel.QueueBind(queueName,exchange:exchangeName,routingKey:eventName);
//创建一个消息消费者，从队列中拉取消息
var consumer=new AsyncEventingBasicConsumer(channel);
//拉取消息，回调
consumer.Received+=Consumer_Received;
//消费消息
channel.BasicConsume(queue: queueName, autoAck: false, consumer: consumer);
Console.ReadLine();//让进程等待消息的消费

async Task Consumer_Received(object sender, BasicDeliverEventArgs args)
{
    try
    {
        var bytes = args.Body.ToArray();
        var msg = Encoding.UTF8.GetString(bytes);
        Console.WriteLine($"{DateTime.Now} 收到了消息：{msg}");
        //消息确认机制，收到Ack，DeliveryTag消息的编号，表明消息被完整的处理了，防止消息未处理完而丢失
        channel.BasicAck(args.DeliveryTag,multiple:false);
        await Task.Delay(1000);//等待1s
    }
    catch (Exception e)
    {
        //消息处理失败，未收到ack，重发消息
        channel.BasicReject(args.DeliveryTag,true);
        Console.WriteLine($"处理收到的消息出错：{e}");
    }
}


