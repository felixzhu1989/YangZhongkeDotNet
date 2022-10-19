using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Nest;
using SearchService.Domain;
using Zack.Commons;

namespace SearchService.Infrastructure
{
    //Install-Package Zack.Commons
    public class ModuleInitializer: IModuleInitializer
    {
        public void Initialize(IServiceCollection services)
        {
            //Install-Package Microsoft.Extensions.Http
            services.AddHttpClient();
            services.AddScoped<IElasticClient>(sp =>
            {
                var option = sp.GetRequiredService<IOptions<ElasticSearchOptions>>();
                var settings = new ConnectionSettings(option.Value.Url);
                return new ElasticClient(settings);
            });
            services.AddScoped<ISearchRepository, SearchRepository>();
        }
    }
}
