// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
//不适用依赖注入
//ITestService t = new TestServiceImp1();
//t.Name = "Tom";
//t.SayHi();

ServiceCollection services = new ServiceCollection();
services.AddTransient<ITestService, TestServiceImp1>();
services.AddTransient<ITestService, TestServiceImp2>();
using ServiceProvider serviceProvider=services.BuildServiceProvider();
var testService = serviceProvider.GetService<ITestService>();
testService.Name = "Tom";
testService.SayHi();
var testServices = serviceProvider.GetServices<ITestService>();
foreach (var s in testServices)
{
    Console.WriteLine(s.GetType());
}

public interface ITestService
{
    public string Name { get; set; }
    public void SayHi();
}

public class TestServiceImp1 : ITestService
{
    public string Name { get; set; }
    public void SayHi()
    {
        Console.WriteLine($"{Name}:Hello World");
    }
}
public class TestServiceImp2 : ITestService
{
    public string Name { get; set; }
    public void SayHi()
    {
        Console.WriteLine($"您好，我是{Name}");
    }
}