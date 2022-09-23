using Microsoft.AspNetCore.Builder;
using Zack.EventBus;

namespace CommonInitializer
{
    public static class ApplicationBuilderExtensions
    {
        //IApplicationBuilder扩展方法，添加各个微服务都需要添加的中间件
        public static IApplicationBuilder UseZackDefault(this IApplicationBuilder app)
        {
            //NuGet安装：Install-Package Zack.EventBus
            app.UseEventBus();//简化集成事件的框架
            app.UseCors();//启用Cors，跨域访问
            app.UseForwardedHeaders();//Nginx？
            app.UseAuthentication();//JWT
            app.UseAuthorization();
            return app;
        }
    }
}