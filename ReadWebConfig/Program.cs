
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ReadWebConfig;


ServiceCollection service=new ServiceCollection();
service.AddScoped<TestWebConfig>();
ConfigurationBuilder builder=new ConfigurationBuilder();
builder.AddFxConfig();//扩展方法
var root =builder.Build();
service.AddOptions().Configure<WebConfig>(e=>root.Bind(e));
using var sp=service.BuildServiceProvider();
var test=sp.GetService<TestWebConfig>();
test!.Test();