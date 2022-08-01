using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionSnapshot
{
    public class Test2Controller
    {
        private readonly IOptionsSnapshot<Proxy> _optProxy;
        public Test2Controller(IOptionsSnapshot<Proxy> optProxy)
        {
            _optProxy = optProxy;
        }

        public void Test()
        {
            Console.WriteLine(_optProxy.Value.Address);
            Console.WriteLine("---------");
            Console.WriteLine(_optProxy.Value.Port);
        }
    }
}
