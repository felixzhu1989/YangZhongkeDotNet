using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Users.Domain;
using Users.Infrastructure;
using Users.WebApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//注册自动提交SaveChangesAsync工作单元中间件
builder.Services.Configure<MvcOptions>(options =>
{
    options.Filters.Add<UnitOfWorkFilter>();
});
//配置上下文对应的数据库，生命周期是Scoped
builder.Services.AddDbContext<UserDbContext>(option =>
{
    //指定连接的数据库
    var connStr = builder.Configuration.GetSection("ConnectionStrings:SqlServer").Value;
    option.UseSqlServer(connStr);
});

//配置Redis分布式缓存
builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = "127.0.0.1:6379";
    options.InstanceName = "dddSmallCase_";//避免混乱，给每个key加前缀
});


//如果是分层项目，则还需要指定其他项目的程序集
//传递当前运行的程序集(响应事件的程序集)
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

//手动注册一些需要的服务，是否需要批量注册上下文？
//在应用层进行所有服务的拼装，选择什么样的接口实现类
builder.Services.AddScoped<UserDomainService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ISmsCodeSender, MockSmsCodeSender>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
