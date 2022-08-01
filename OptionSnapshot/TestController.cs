using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace OptionSnapshot
{
    public class TestController
    {
        private readonly IOptionsSnapshot<Config> _optConfig;
        public TestController(IOptionsSnapshot<Config> optConfig)
        {
            _optConfig = optConfig;
        }

        public void Test()
        {
            Console.WriteLine(_optConfig.Value.Name);
            Console.WriteLine("---------");
            Console.WriteLine(_optConfig.Value.Age);
        }
    }
}
