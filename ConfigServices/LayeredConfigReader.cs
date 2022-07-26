using System;
using System.Collections.Generic;
using System.Text;

namespace ConfigServices
{
    class LayeredConfigReader:IConfigReader
    {
        private readonly IEnumerable<IConfigService> _services;
        public LayeredConfigReader(IEnumerable<IConfigService> services)
        {
            _services = services;
        }
        public string GetValue(string name)
        {
            string value=null;
            foreach (var service in _services)
            {
                string newValue = service.GetValue(name);
                if (newValue != null) value=newValue;//最后一个不为null的值就是最终值
            }
            return value;
        }
    }
}
