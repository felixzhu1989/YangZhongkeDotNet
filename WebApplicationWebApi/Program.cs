using Zack.ASPNETCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMemoryCache();
builder.Services.AddScoped<IMemoryCacheHelper, MemoryCacheHelper>();
builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = "127.0.0.1:6379";
    options.InstanceName = "felix_";//������ң���ÿ��key��ǰ׺
});
builder.Services.AddScoped<IDistributedCacheHelper, DistributedCacheHelper>();

//��Щǰ���ǿ����ε�
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("http://localhost:5173")
            .AllowAnyMethod().AllowAnyHeader().AllowCredentials();
    });
});

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();//�������
app.UseResponseCaching();//���÷���������Ӧ����
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
