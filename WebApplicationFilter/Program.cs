using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using WebApplicationFilter;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//配置过滤器
builder.Services.Configure<MvcOptions>(options =>
{
    //注册异常过滤器
    options.Filters.Add<MyExceptionFilter>();
    //注册Action过滤器
    options.Filters.Add<FirstActionFilter>();
    options.Filters.Add<SecondActionFilter>();
});

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
