using Microsoft.Extensions.Configuration;

ConfigurationBuilder configBuilder = new ConfigurationBuilder();
configBuilder.AddJsonFile("config.json", optional: true, reloadOnChange: true);
var configRoot=configBuilder.Build();
/*
var name= configRoot["name"];//简单的
var address = configRoot.GetSection("proxy:address").Value;//多层级
Console.WriteLine($"name={name},address={address}");
*/

var config = configRoot.Get<Config>();//直接将根节点映射为对象
var proxy = configRoot.GetSection("proxy").Get<Proxy>();//将层级节点映射为对象
Console.WriteLine($"name={config.Name},age={config.Age}");
Console.WriteLine($"port={proxy.Address},port={proxy.Port}");
Console.WriteLine($"ids0={proxy.Ids[0]},ids1={proxy.Ids[1]},ids2={proxy.Ids[2]}");

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