using System.Reflection;
using MediatR;
using Microsoft.EntityFrameworkCore;
using WebApplicationMediatR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//����Ƿֲ���Ŀ������Ҫָ��������Ŀ�ĳ���
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());//���ݵ�ǰ���еĳ���

//���������Ķ�Ӧ�����ݿ⣬����������Scoped
builder.Services.AddDbContext<MyDbContext>(option =>
{
    //ָ�����ӵ����ݿ�
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

app.UseAuthorization();

app.MapControllers();

app.Run();
