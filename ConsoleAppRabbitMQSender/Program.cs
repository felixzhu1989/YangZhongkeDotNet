using System.Globalization;
using System.Text;
using RabbitMQ.Client;

var connFactory = new ConnectionFactory
{
    HostName = "127.0.0.1", //RabbitMQ服务器地址
    DispatchConsumersAsync = true
};
var connection = connFactory.CreateConnection();//创建连接
var exchangeName = "exchange1";//交换机的名字
var eventName = "myEvent";//routingKey的值
while (true)
{
    using var channel = connection.CreateModel();//创建信道
    var prop = channel.CreateBasicProperties();
    prop.DeliveryMode = 2;//消息持久化
    //声明交换机(交换机名，类型direct)
    channel.ExchangeDeclare(exchangeName, "direct");
    //因为消息只支持byte[]数组，因此需要进行编码
    byte[] bytes = Encoding.UTF8.GetBytes(DateTime.Now.ToString(CultureInfo.CurrentCulture));
    //发送消息
    channel.BasicPublish(exchangeName, routingKey:eventName,mandatory:true,basicProperties:prop,body:bytes);

    Console.WriteLine($"消息已发出：{DateTime.Now}");
    Thread.Sleep(1000);//暂停1s,因为是死循环，一次会每隔1s发送一次消息
}