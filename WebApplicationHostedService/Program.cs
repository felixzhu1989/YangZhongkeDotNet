using Microsoft.EntityFrameworkCore;
using WebApplicationHostedService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//配置后台托管服务
builder.Services.AddHostedService<HostedServiceTest>();
//注册短周期服务
builder.Services.AddScoped<TestService>();


builder.Services.AddHostedService<ScheduledService>();

//配置上下文对应的数据库，生命周期是Scoped
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
