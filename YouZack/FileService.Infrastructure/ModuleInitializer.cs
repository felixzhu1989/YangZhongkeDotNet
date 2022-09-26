using FileService.Domain;
using FileService.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using Zack.Commons;

namespace FileService.Infrastructure
{
    public class ModuleInitializer:IModuleInitializer
    {
        public void Initialize(IServiceCollection services)
        {
            //HttpContextAccessor 默认实现了它简化了访问HttpContext。用来访问HttpContext
            services.AddHttpContextAccessor();
            services.AddScoped<IStorageClient, SMBStorageClient>();//本机磁盘当备份服务器
            services.AddScoped<IStorageClient, MockCloudStorageClient>();//文件保存在wwwroot文件夹下
            //services.AddScoped<IStorageClient, UpYunStorageClient>();//云存储

            services.AddScoped<IFSRepository, FSRepository>();
            services.AddScoped<FSDomainService>();

            services.AddHttpClient();//了解一下类型化HttClient使用方式
        }
    }
}
