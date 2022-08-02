using System.Xml;
using Microsoft.Extensions.Configuration;

namespace ReadWebConfig
{
    public class FxConfigProvider : FileConfigurationProvider
    {
        public FxConfigProvider(FxConfigSource source) : base(source)
        {
        }
        public override void Load(Stream stream)
        {
            //主要的逻辑就是解析xml文件，然后按照扁平化处理规则，将数据填入键值对data字典中
            //StringComparer.OrdinalIgnoreCase忽略大小写
            var data = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(stream);
            var csNodes = xmlDoc.SelectNodes("/configuration/connectionStrings/add");
            foreach (var xmlNode in csNodes!.Cast<XmlNode>())
            {
                
                var name = xmlNode.Attributes!["name"]!.Value;
                var connectionString = xmlNode.Attributes!["connectionString"]!.Value;
                //扁平化处理，将xml映射成如下结构
                //[name1:{connectionString:"xxx",providerName:"xxx"},name2:{connectionString:"xxx",providerName:"xxx"}]
                data[$"{name}:connectionString"] = connectionString;

                var providerName = xmlNode.Attributes!["providerName"];
                if (providerName != null)
                {
                    data[$"{name}:providerName"] = providerName.Value;
                }
            }
            var asNodes = xmlDoc.SelectNodes("/configuration/appSettings/add");
            foreach (var xmlNode in asNodes!.Cast<XmlNode>())
            {

                var key = xmlNode.Attributes!["key"]!.Value;
                key = key.Replace('.', ':');//将逗号替换成冒号
                var value = xmlNode.Attributes!["value"]!.Value;
                data[key] = value;
            }
            this.Data=data;
        }
    }
}
