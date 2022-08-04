using ConsoleLogging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

ServiceCollection service=new ServiceCollection();
//如何输出日志，由框架配置
service.AddLogging(logBuilder =>
{
    logBuilder.AddConsole();
    logBuilder.AddEventLog();
    logBuilder.SetMinimumLevel(LogLevel.Debug);//最低输出那些级别的信息，这条可以通过文件配置
});

service.AddScoped<Test>();
using var sp = service.BuildServiceProvider();
var test=sp.GetRequiredService<Test>();
test.TestDebug();
