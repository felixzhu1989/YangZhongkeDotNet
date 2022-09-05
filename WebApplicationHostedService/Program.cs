using Microsoft.EntityFrameworkCore;
using WebApplicationHostedService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//���ú�̨�йܷ���
builder.Services.AddHostedService<HostedServiceTest>();
//ע������ڷ���
builder.Services.AddScoped<TestService>();


builder.Services.AddHostedService<ScheduledService>();

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
