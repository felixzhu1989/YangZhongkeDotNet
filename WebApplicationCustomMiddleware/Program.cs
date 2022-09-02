using System.Reflection;
using System.Xml.Schema;
using WebApplicationCustomMiddleware;
using WebApplicationCustomMiddleware.MiniWebApi;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
ActionLocator locator = new ActionLocator(services, Assembly.GetEntryAssembly()!);
services.AddSingleton(locator);
services.AddMemoryCache();
//添加自定义过滤器
ActionFilters.Filters.Add(new MyActionFilter());
var app = builder.Build();
//注册自定义中间件
app.UseMiddleware<MyStaticFilesMiddleware>();
app.UseMiddleware<MyWebAPIMiddleware>();
app.UseMiddleware<NotFoundMiddleware>();

/*app.MapGet("/", () => "Hello World!");
app.MapGet("/felix", () => "felix!");

app.Map("/test", async pipeBuilder =>
{
    //检查中间件，放在最前面
    pipeBuilder.UseMiddleware<CheckAndParsingMiddleware>();
    pipeBuilder.Use(async (context, next) =>
    {
        context.Response.ContentType = "text/html";
        await context.Response.WriteAsync("1 start<br/>");
        await next.Invoke();
        await context.Response.WriteAsync("1 end<br/>");
    });
    pipeBuilder.Use(async (context, next) =>
    {
        await context.Response.WriteAsync("2 start<br/>");
        await next.Invoke();
        await context.Response.WriteAsync("2 end<br/>");
    });
    pipeBuilder.Run(async context =>
    {
        await context.Response.WriteAsync("Hello Middleware<br/>");
        //从Items中取出BodyJson
        var obj = context.Items["BodyJson"];
        if (obj!=null) await context.Response.WriteAsync($"{obj}<br/>");
    });
});*/

app.Run();
