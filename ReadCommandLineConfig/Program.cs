using Microsoft.Extensions.Configuration;

ConfigurationBuilder configBuilder = new ConfigurationBuilder();
//configBuilder.AddCommandLine(args);
configBuilder.AddEnvironmentVariables("C1_");
var configRoot = configBuilder.Build();

var config = configRoot.Get<Config>();//直接将根节点映射为对象
var proxy = configRoot.GetSection("proxy").Get<Proxy>();//将层级节点映射为对象
Console.WriteLine($"name={config.Name},age={config.Age}");
Console.WriteLine($"port={proxy.Address},port={proxy.Port}");
Console.WriteLine($"ids={string.Join(',',proxy.Ids)}");
class Config
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Proxy Proxy { get; set; }
}
class Proxy
{
    public string Address { get; set; }
    public int Port { get; set; }
    //数组
    public int[] Ids { get; set; }
}
