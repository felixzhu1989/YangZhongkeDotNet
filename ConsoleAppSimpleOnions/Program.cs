using ClassLibrarySimpleOnions;
using ConsoleAppSimpleOnions;
using Microsoft.Extensions.DependencyInjection;


/*//原始的实现，耦合性太强
//可能不是从本地文件读取信息
var lines=await File.ReadAllLinesAsync("d://temp.txt");
foreach (var line in lines)
{
    var segments = line.Split('|');
    var email = segments[0];
    var title=segments[1];
    var body=segments[2];
    //可以是使用smtp，也可能是使用邮件服务
    Console.WriteLine($"假装往{email}发送邮件，标题：{title}，内容：{body}");
}*/

//解耦，抽象化
ServiceCollection service=new ServiceCollection();
service.AddScoped<SendEmailBusinessLogic>();
service.AddScoped<IEmailSender,MyEmailSender>();
service.AddScoped<IDataProvider,MyDataProvider>();

var serviceProvider=service.BuildServiceProvider();
var sender=serviceProvider.GetRequiredService<SendEmailBusinessLogic>();
await sender.DoItAsync();
