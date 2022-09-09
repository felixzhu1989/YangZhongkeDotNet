using WebApplicationImportEcDict;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors();
//����SignalR,����redis��Ϣ���ķ�����
builder.Services.AddSignalR();
builder.Services.AddScoped<ImportExecutor>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseCors();//������ʣ���UseHttpsRedirection֮ǰ
app.UseCors(x => x.WithOrigins("https://localhost:7192")
    .AllowAnyHeader()
    .AllowAnyMethod()
    .AllowCredentials()
);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapHub<ImportHub>("/ImportHub");//��MapControllers֮ǰ

app.MapControllers();

app.Run();
