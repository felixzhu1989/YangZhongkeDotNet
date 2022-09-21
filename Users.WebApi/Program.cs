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
//ע���Զ��ύSaveChangesAsync������Ԫ�м��
builder.Services.Configure<MvcOptions>(options =>
{
    options.Filters.Add<UnitOfWorkFilter>();
});
//���������Ķ�Ӧ�����ݿ⣬����������Scoped
builder.Services.AddDbContext<UserDbContext>(option =>
{
    //ָ�����ӵ����ݿ�
    var connStr = builder.Configuration.GetSection("ConnectionStrings:SqlServer").Value;
    option.UseSqlServer(connStr);
});

//����Redis�ֲ�ʽ����
builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = "127.0.0.1:6379";
    options.InstanceName = "dddSmallCase_";//������ң���ÿ��key��ǰ׺
});


//����Ƿֲ���Ŀ������Ҫָ��������Ŀ�ĳ���
//���ݵ�ǰ���еĳ���(��Ӧ�¼��ĳ���)
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

//�ֶ�ע��һЩ��Ҫ�ķ����Ƿ���Ҫ����ע�������ģ�
//��Ӧ�ò�������з����ƴװ��ѡ��ʲô���Ľӿ�ʵ����
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
