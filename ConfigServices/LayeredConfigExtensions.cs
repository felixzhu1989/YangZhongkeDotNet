using System;
using System.Collections.Generic;
using System.Text;
using ConfigServices;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class LayeredConfigExtensions
    {
        public static void AddLayeredConfig(this IServiceCollection service)
        {
            service.AddScoped<IConfigReader,LayeredConfigReader>();
        }
    }
}
