using System;
using System.Collections.Generic;
using System.Text;

namespace ConfigServices
{
    public class EnvVarConfigService:IConfigService
    {
        public string GetValue(string name)
        {
            return Environment.GetEnvironmentVariable(name);
        }
    }
}
