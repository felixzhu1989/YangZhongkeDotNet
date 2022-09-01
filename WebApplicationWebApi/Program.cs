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
    options.InstanceName = "felix_";//避免混乱，给每个key加前缀
});
builder.Services.AddScoped<IDistributedCacheHelper, DistributedCacheHelper>();

//那些前端是可信任的
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

app.UseCors();//跨域访问
app.UseResponseCaching();//启用服务器端响应缓存
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
