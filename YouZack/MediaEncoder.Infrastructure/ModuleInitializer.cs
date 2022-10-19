using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaEncoder.Domain;
using Microsoft.Extensions.DependencyInjection;
using Zack.Commons;

namespace MediaEncoder.Infrastructure
{
    public class ModuleInitializer:IModuleInitializer
    {
        public void Initialize(IServiceCollection services)
        {
            services.AddScoped<IMediaEncoderRepository,MediaEncoderRepository>();
            services.AddScoped<IMediaEncoder, ToM4AEncoder>();
        }
    }
}
