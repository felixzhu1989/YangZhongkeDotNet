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

//���ù�����
builder.Services.Configure<MvcOptions>(options =>
{
    //ע���쳣������
    options.Filters.Add<MyExceptionFilter>();
    //ע��Action������
    options.Filters.Add<FirstActionFilter>();
    options.Filters.Add<SecondActionFilter>();
});

//����EFCoreBooks��Ŀ�������Ķ�Ӧ�����ݿ⣬����������Scoped
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
