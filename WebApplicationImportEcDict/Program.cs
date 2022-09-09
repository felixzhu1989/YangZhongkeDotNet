using WebApplicationImportEcDict;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors();
//配置SignalR,配置redis消息中心服务器
builder.Services.AddSignalR();
builder.Services.AddScoped<ImportExecutor>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseCors();//跨域访问，在UseHttpsRedirection之前
app.UseCors(x => x.WithOrigins("https://localhost:7192")
    .AllowAnyHeader()
    .AllowAnyMethod()
    .AllowCredentials()
);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapHub<ImportHub>("/ImportHub");//在MapControllers之前

app.MapControllers();

app.Run();
