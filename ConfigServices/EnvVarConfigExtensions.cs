using ConfigServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class EnvVarConfigExtensions
    {
        public static void AddEnvVarConfig(this IServiceCollection service)
        {
            service.AddScoped<IConfigService, EnvVarConfigService>();
        }
    }
}
