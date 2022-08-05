using ConsoleLogging;
using Exceptionless;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using Serilog;
using Serilog.Formatting.Json;
using SystemServices;

ExceptionlessClient.Default.Startup("esUxvEgGWxnMqWJ8qIPTqxLSBjASmvnPyjDyIYfS");
ServiceCollection service=new ServiceCollection();
//如何输出日志，由框架配置
service.AddLogging(logBuilder =>
{
    //logBuilder.AddConsole();
    //logBuilder.AddEventLog();//将日志添加到日志查看器搜索event viewer
    //logBuilder.AddNLog();
    //logBuilder.SetMinimumLevel(LogLevel.Debug);//最低输出那些级别的信息，这条可以通过文件配置

    //通过代码配置，当然也可以通过文件配置，查看官方文档
    Log.Logger = new LoggerConfiguration()
        .MinimumLevel.Debug()
        .Enrich.FromLogContext()
        .WriteTo.Console(new JsonFormatter())
        .WriteTo.Exceptionless()
        .CreateLogger();
    logBuilder.AddSerilog();
});

service.AddScoped<Test>();
service.AddScoped<Test2>();
using var sp = service.BuildServiceProvider();
var test=sp.GetRequiredService<Test>();
test.TestDebug();
//var test2 = sp.GetRequiredService<Test2>();
//test2.TestDebug();
