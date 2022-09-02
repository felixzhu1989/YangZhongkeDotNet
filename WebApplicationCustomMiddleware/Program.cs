using System.Reflection;
using System.Xml.Schema;
using WebApplicationCustomMiddleware;
using WebApplicationCustomMiddleware.MiniWebApi;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
ActionLocator locator = new ActionLocator(services, Assembly.GetEntryAssembly()!);
services.AddSingleton(locator);
services.AddMemoryCache();
//����Զ��������
ActionFilters.Filters.Add(new MyActionFilter());
var app = builder.Build();
//ע���Զ����м��
app.UseMiddleware<MyStaticFilesMiddleware>();
app.UseMiddleware<MyWebAPIMiddleware>();
app.UseMiddleware<NotFoundMiddleware>();

/*app.MapGet("/", () => "Hello World!");
app.MapGet("/felix", () => "felix!");

app.Map("/test", async pipeBuilder =>
{
    //����м����������ǰ��
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
        //��Items��ȡ��BodyJson
        var obj = context.Items["BodyJson"];
        if (obj!=null) await context.Response.WriteAsync($"{obj}<br/>");
    });
});*/

app.Run();
