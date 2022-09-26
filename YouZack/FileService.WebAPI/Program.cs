using CommonInitializer;
using FileService.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//���ݿ�
builder.ConfigureDbConfiguration();
//�������ã���ʼ��InitializerOptions��Ϊ�������ݣ�LogFilePath��EventBusQueueName
builder.ConfigureExtraServices(new InitializerOptions()
{
    LogFilePath = "d:/temp/FileService.log",//��¼��־�ļ���λ��
    EventBusQueueName = "FileService.WebApi"//RabbitMQ���е�����
});
//asp.net core��Ŀ��AddOptions()��дҲ�У���Ϊ���һ���Զ�ִ����
//�������ж�ȡSMBStorageOptions������Ŀ¼��ַ
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
app.UseZackDefault();//������һϵ���м����ʹ��
app.MapControllers();
app.Run();
