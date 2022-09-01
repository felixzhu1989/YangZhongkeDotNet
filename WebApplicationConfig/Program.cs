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
    //��Program.cs�ж�ȡ���õ�һ�ַ���
    var connStr = builder.Configuration.GetValue<string>("Redis");
    return ConnectionMultiplexer.Connect(connStr);
});
//��SmtpSettings����Smtp�ڵ��������
builder.Services.Configure<SmtpSettings>(builder.Configuration.GetSection("Smtp"));

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

/*var connString = app.Configuration.GetSection("connString").Value;
Console.WriteLine(connString);*/

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
