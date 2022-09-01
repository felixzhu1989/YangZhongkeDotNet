using System.Xml.Schema;
using WebApplicationCustomMiddleware;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
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
});

app.Run();
