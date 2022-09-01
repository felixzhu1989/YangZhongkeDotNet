using EFCoreBooks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using StackExchange.Redis;
using WebApplicationConfig;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Host.ConfigureAppConfiguration((hostCtx, configBuilder) => {
    var connStr = builder.Configuration.GetSection("ConnStr").Value;
    configBuilder.AddDbConfiguration(() => new SqlConnection(connStr), reloadOnChange: true, reloadInterval: TimeSpan.FromSeconds(2));
});
builder.Services.AddSingleton<IConnectionMultiplexer>(sp =>
{
    //在Program.cs中读取配置的一种方法
    var connStr = builder.Configuration.GetValue<string>("Redis");
    return ConnectionMultiplexer.Connect(connStr);
});
//将SmtpSettings类与Smtp节点绑定起来了
builder.Services.Configure<SmtpSettings>(builder.Configuration.GetSection("Smtp"));

//配置EFCoreBooks项目的上下文对应的数据库，生命周期是Scoped
builder.Services.AddDbContext<MyDbContext>(option =>
{
    //指定连接的数据库
    var connStr = builder.Configuration.GetSection("ConnectionStrings:SqlServer").Value;
    option.UseSqlServer(connStr);
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

/*var connString = app.Configuration.GetSection("connString").Value;
Console.WriteLine(connString);*/

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
