// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;

ServiceCollection service=new ServiceCollection();
service.AddScoped<Controller>();
service.AddScoped<ILog, LogImpl>();
//service.AddScoped<IConfig, ConfigImpl>();
service.AddScoped<IConfig, DbConfigImpl>();
service.AddScoped<IStorage, StorageImpl>();
using var serviceProvider= service.BuildServiceProvider();
//Controller由容器创建，则它使用到的类由容器自动创建(传染性)
var controller = serviceProvider.GetRequiredService<Controller>();
controller.Test();


class Controller
{
    private readonly ILog _log;
    private readonly IStorage _storage;
    public Controller(ILog log,IStorage storage)
    {
        _log = log;
        _storage = storage;
    }

    public void Test()
    {
        _log.Log("开始上传");
        _storage.Save("Hello World","hello.txt");
        _log.Log("上传完成");
    }
}

interface ILog
{
    public void Log(string message);
}

class LogImpl : ILog
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}

interface IConfig
{
    public string GetValue(string name);
}
class ConfigImpl : IConfig
{
    public string GetValue(string name)
    {
        Console.WriteLine("从本地读取配置");
        return $"Local{name}";
    }
}
class DbConfigImpl : IConfig
{
    public string GetValue(string name)
    {
        Console.WriteLine("从数据库读取配置");
        return $"Db{name}";
    }
}
interface IStorage
{
    public void Save(string content, string name);
}

class StorageImpl : IStorage
{
    //写存储实现的时候根本不用关心配置从哪里来，因为它由框架提供
    //写业务的人只需要说我要这个服务就行了
    private readonly IConfig _config;
    public StorageImpl(IConfig config)
    {
        _config = config;
    }
    public void Save(string content, string name)
    {
      var server=  _config.GetValue("Server");
      Console.WriteLine($"向服务器{server}的文件名为{name}上传{content}");
    }
}