namespace ReadWebConfig
{
    //按照扁平化处理的格式，声明这个类
    public class WebConfig
    {
        public ConnectStr ConnStr1 { get; set; }
        public ConnectStr ConnStr2 { get; set; }
        public Config Config { get; set; }//config:proxy:port
    }

    public class ConnectStr
    {
        public string ConnectionString { get; set; }
        public string ProviderName { get; set; }
    }

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
        //数组
        public int[] Ids { get; set; }
    }
}
