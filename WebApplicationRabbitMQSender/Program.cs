using System.Reflection;
using Zack.EventBus;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//正式项目请将配置放到配置文件或者数据库中，我们这里写死配置项
builder.Services.Configure<IntegrationEventRabbitMQOptions>(options =>
{
    options.HostName = "127.0.0.1";
    options.ExchangeName = "exchangeEventBus";
});
//当前程序集监听queue1队列的消息
builder.Services.AddEventBus("queue1",Assembly.GetExecutingAssembly());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseEventBus();

app.UseAuthorization();

app.MapControllers();

app.Run();
