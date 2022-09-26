using CommonInitializer;
using FileService.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//数据库
builder.ConfigureDbConfiguration();
//常用配置，初始化InitializerOptions作为参数传递，LogFilePath，EventBusQueueName
builder.ConfigureExtraServices(new InitializerOptions()
{
    LogFilePath = "d:/temp/FileService.log",//记录日志文件的位置
    EventBusQueueName = "FileService.WebApi"//RabbitMQ队列的名字
});
//asp.net core项目中AddOptions()不写也行，因为框架一定自动执行了
//从配置中读取SMBStorageOptions，备份目录地址
builder.Services//.AddOptions()
    .Configure<SMBStorageOptions>(builder.Configuration.GetSection("FileService:SMB"));
//.Configure<UpYunStorageOptions>(builder.Configuration.GetSection("FileService:UpYun"));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddSwaggerGen(c =>
//{
//    c.SwaggerDoc("v1",new OpenApiInfo()
//    {
//        Title = "FileService.WebAPI",Version = "v1"
//    });
//});

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.UseDeveloperExceptionPage();
app.UseSwagger();
app.UseSwaggerUI();
//app.UseSwaggerUI(c =>
//{
//    c.SwaggerEndpoint("/swagger/v1/swagger.json", "FileService.WebAPI v1");
//});


app.UseStaticFiles();
app.UseZackDefault();//包含了一系列中间件的使用
app.MapControllers();
app.Run();
