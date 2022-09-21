using System.Reflection;
using Zack.EventBus;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//��ʽ��Ŀ�뽫���÷ŵ������ļ��������ݿ��У���������д��������
builder.Services.Configure<IntegrationEventRabbitMQOptions>(options =>
{
    options.HostName = "127.0.0.1";
    options.ExchangeName = "exchangeEventBus";
});
//��ǰ���򼯼���queue1���е���Ϣ
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
