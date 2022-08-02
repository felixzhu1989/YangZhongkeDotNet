using Microsoft.Extensions.Configuration;

namespace ReadWebConfig
{
    //Source主要是提供参数
    public class FxConfigSource:FileConfigurationSource
    {
        public override IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            EnsureDefaults(builder);//处理Path等默认值的问题
            return new FxConfigProvider(this);
        }
    }
}
