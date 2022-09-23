using FluentValidation;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using StackExchange.Redis;
using Swashbuckle.AspNetCore.SwaggerGen;
using Zack.ASPNETCore;
using Zack.Commons;
using Zack.Commons.JsonConverters;
using Zack.EventBus;
using Zack.JWT;

namespace CommonInitializer
{
    public static class WebApplicationBuilderExtensions
    {
        //配置数据库
        public static void ConfigureDbConfiguration(this WebApplicationBuilder builder)
        {
            builder.Host.ConfigureAppConfiguration((hostCtx, configBuilder) =>
            {
                //不能使用ConfigureAppConfiguration中的configBuilder去读取配置，否则就循环调用了，因此这里直接自己去读取配置文件
                //var configRoot = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
                //string connStr = configRoot.GetValue<string>("DefaultDB:ConnStr");
                string connStr = builder.Configuration.GetValue<string>("DefaultDB:ConnStr");
                //NuGet安装：Install-Package Zack.AnyDBConfigProvider
                configBuilder.AddDbConfiguration(() => new SqlConnection(connStr), reloadOnChange: true, reloadInterval: TimeSpan.FromSeconds(5));
            });
        }

        
        //常用配置，调用初始化InitializerOptions作为参数传递，LogFilePath，EventBusQueueName
        public static void ConfigureExtraServices(this WebApplicationBuilder builder, InitializerOptions initOptions)
        {
            IServiceCollection services = builder.Services;
            IConfiguration configuration = builder.Configuration;

            //NuGet安装：Install-Package Zack.Commons
            //loop through all assemblies
            var assemblies = ReflectionHelper.GetAllReferencedAssemblies();
            //每个项目中都可以自己写一些实现了IModuleInitializer接口的类，
            //在其中注册自己需要的服务，这样避免所有内容到入口项目中注册
            //各项目在Infrastructure-ModuleInitializer注册自己的服务
            services.RunModuleInitializers(assemblies);

            //NuGet安装：Install-Package Zack.Infrastructure
            //批量注册上下文
            services.AddAllDbContexts(ctx =>
            {
                //连接字符串如果放到appsettings.json中，会有泄密的风险
                //如果放到UserSecrets中，每个项目都要配置，很麻烦
                //因此这里推荐放到环境变量中。
                string connStr = configuration.GetValue<string>("DefaultDB:ConnStr");
                ctx.UseSqlServer(connStr);
            },assemblies);

            //NuGet安装：Install-Package Zack.JWT
            //开始:Authentication,Authorization
            //只要需要校验Authentication报文头的地方（非IdentityService.WebAPI项目）也需要启用这些
            //IdentityService项目还需要启用AddIdentityCore
            services.AddAuthorization();
            services.AddAuthentication();
            JWTOptions jwtOpt = configuration.GetSection("JWT").Get<JWTOptions>();
            services.AddJWTAuthentication(jwtOpt);
            //启用Swagger中的【Authorize】按钮。这样就不用每个项目的AddSwaggerGen中单独配置了
            services.Configure<SwaggerGenOptions>(c =>
            {
                c.AddAuthenticationHeader();
            });
            //结束:Authentication,Authorization

            //NuGet安装：Install-Package Zack.ASPNETCore
            //领域事件，注册工作单元中间件，统一执行SaveChangesAsync
            services.AddMediatR(assemblies);
            //现在不用手动AddMVC了，因此把文档中的services.AddMvc(options =>{})改写成Configure<MvcOptions>(options=> {})这个问题很多都类似
            services.Configure<MvcOptions>(options =>
            {
                options.Filters.Add<UnitOfWorkFilter>();
            });
            services.Configure<JsonOptions>(options =>
            {
                //设置时间格式。而非“2008-08-08T08:08:08”这样的格式
                options.JsonSerializerOptions.Converters.Add(new DateTimeJsonConverter("yyyy-MM-dd HH:mm:ss"));
            });

            //配置跨域访问
            services.AddCors(options =>
            {
                //更好的在Program.cs中用绑定方式读取配置的方法：https://github.com/dotnet/aspnetcore/issues/21491
                //不过比较麻烦。

                //将发出跨域请求的地址从中心配置服务器中读取出来，再配置跨域
                //读取配置并绑定到CorsSettings类型的对象
                var corsOpt = configuration.GetSection("Cors").Get<CorsSettings>();
                var urls = corsOpt.Origins;
                options.AddDefaultPolicy(corsPolicyBuilder=>corsPolicyBuilder.WithOrigins(urls)
                    .AllowAnyMethod().AllowAnyHeader().AllowCredentials());
            });

            //NuGet安装：Install-Package Serilog.AspNetCore
            //配置Serilog日志，LogFilePath从调用者（program）初始化InitializerOptions而来
            services.AddLogging(loggingBuilder =>
            {
                Log.Logger = new LoggerConfiguration()
                    // .MinimumLevel.Information().Enrich.FromLogContext()
                    .WriteTo.Console()
                    .WriteTo.File(initOptions.LogFilePath) //记录日志到调用者初始化设定的位置
                    .CreateLogger();
                loggingBuilder.AddSerilog();
            });

            //NuGet安装：Install-Package FluentValidation.AspNetCore
            //配置FluentValidation，请求数据校验
            services.AddFluentValidationAutoValidation().AddValidatorsFromAssemblies(assemblies);

            //配置JWT的选项，包含secKey和过期时间
            services.Configure<JWTOptions>(configuration.GetSection("JWT"));

            //配置RabbitMQ，从中心化服务器读取RabbitMQ的服务器地址和交换机名
            services.Configure<IntegrationEventRabbitMQOptions>(configuration.GetSection("RabbitMQ"));
            //配置消息队列名，EventBusQueueName从调用者（program）初始化InitializerOptions而来
            services.AddEventBus(initOptions.EventBusQueueName, assemblies);

            //配置Redis的服务器，分布式缓存
            string redisConnStr = configuration.GetValue<string>("Redis:ConnStr");
            IConnectionMultiplexer redisConnMultiplexer = ConnectionMultiplexer.Connect(redisConnStr);
            services.AddSingleton(typeof(IConnectionMultiplexer), redisConnMultiplexer);

            //Nginx请求地址反向代理与分发
            services.Configure<ForwardedHeadersOptions>(options =>
            {
                options.ForwardedHeaders = ForwardedHeaders.All;
            });
        }
    }
}
