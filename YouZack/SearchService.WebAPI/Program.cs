using CommonInitializer;
using SearchService.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.ConfigureDbConfiguration();
builder.ConfigureExtraServices(new InitializerOptions
{
    LogFilePath = "d:/temp/SearchService.log",
    EventBusQueueName = "SearchService.WebAPI"
});
builder.Services.Configure<ElasticSearchOptions>(builder.Configuration.GetSection("ElasticSearch"));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}
app.UseSwagger();
app.UseSwaggerUI();
app.UseDeveloperExceptionPage();
app.UseZackDefault();
app.MapControllers();
app.Run();
