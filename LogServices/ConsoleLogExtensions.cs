using LogServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ConsoleLogExtensions
    {
        public static void AddConsoleLog(this IServiceCollection service)
        {
            service.AddScoped<ILogProvider, ConsoleLogProvider>();
        }
    }
}
