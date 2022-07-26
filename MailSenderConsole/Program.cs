// See https://aka.ms/new-console-template for more information

using MailServices;
using Microsoft.Extensions.DependencyInjection;

ServiceCollection service=new ServiceCollection();
//service.AddScoped<IConfigService, EnvVarConfigService>();
//使用回调的方式注册服务，因为必须给服务对象的属性赋值
//service.AddScoped<IConfigService>(s=>new IniFileConfigService{FilePath = "mail.ini"});
//service.AddScoped<IMailService, MailService>();
//service.AddScoped<ILogProvider, ConsoleLogProvider>();

//用户无需知道具体类的名字，直接.出需要添加的服务
service.AddEnvVarConfig();
service.AddIniFileConfig("mail.ini");
service.AddLayeredConfig();
service.AddMailSender();
service.AddConsoleLog();

using var serviceProvider = service.BuildServiceProvider();
var mailService = serviceProvider.GetRequiredService<IMailSenderService>();
mailService.Send("Hello","trump@usa.gov","懂王，您好！");
