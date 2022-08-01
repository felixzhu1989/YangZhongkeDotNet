﻿// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OptionSnapshot;

ServiceCollection service=new ServiceCollection();

ConfigurationBuilder configBuilder = new ConfigurationBuilder();
configBuilder.AddJsonFile("config.json", optional: true, reloadOnChange: true);
var configRoot = configBuilder.Build();

//将Option先注册到Di框架中，将Config对象绑定到根节点上(!!!重要)
service.AddOptions().Configure<Config>(e => configRoot.Bind(e))
    .Configure<Proxy>(e=>configRoot.GetSection("proxy").Bind(e));

service.AddScoped<TestController>();
service.AddScoped<Test2Controller>();

using var serviceProvider=service.BuildServiceProvider();
var controller=serviceProvider.GetRequiredService<TestController>();
controller.Test();
var controller2 = serviceProvider.GetRequiredService<Test2Controller>();
controller2.Test();

public class Config
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Proxy Proxy { get; set; }
}
public class Proxy
{
    public string Address { get; set; }
    public int Port { get; set; }
}