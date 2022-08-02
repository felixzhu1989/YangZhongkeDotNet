using Microsoft.Extensions.Options;

namespace ReadWebConfig
{
    public class TestWebConfig
    {
        private readonly IOptionsSnapshot<WebConfig> _options;
        public TestWebConfig(IOptionsSnapshot<WebConfig> options)
        {
            _options = options;
        }
        public void Test()
        {
            var wc = _options.Value;
            Console.WriteLine(wc.ConnStr1.ConnectionString);
            Console.WriteLine(wc.Config.Name);
            Console.WriteLine(wc.Config.Proxy.Address);
        }
    }
}
