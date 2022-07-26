using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using ConfigServices;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class IniFileConfigExtensions
    {
        public static void AddIniFileConfig(this IServiceCollection service,string filePath)
        {
            service.AddScoped<IConfigService>(s => new IniFileConfigService() {FilePath = filePath});
        }
    }
}
