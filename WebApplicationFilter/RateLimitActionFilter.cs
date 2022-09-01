using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Caching.Memory;

namespace WebApplicationFilter
{
    public class RateLimitActionFilter:IAsyncActionFilter
    {
        //注入内存缓存
        private readonly IMemoryCache _memoryCache;
        public RateLimitActionFilter(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var remoteIp = context.HttpContext.Connection.RemoteIpAddress.ToString();//获取访问用户的IP地址
            var cacheKey = $"LastVisitTick_{remoteIp}";//用方位IP地址作为内存缓存的Key
            var lastTick = _memoryCache.Get<long?>(cacheKey);//从内存缓存中查找Key对应的时间
            //如果查找的时间不存在，或者距离上一次访问时间超过1秒
            if (lastTick == null || Environment.TickCount64 - lastTick > 1000)
            {
                //在内存缓存中记录当前访问时间，并设置内存缓存过期时间为5秒，避免长期占用内存
                _memoryCache.Set(cacheKey, Environment.TickCount64, TimeSpan.FromSeconds(5));
                return next();//简单转发，不要使用async await
            }
            //不调用await next，就可以终止Action方法的执行。
            context.Result = new ContentResult {StatusCode = 429,Content = "访问太频繁" };//429代表访问过于频繁
            return Task.CompletedTask;
        }
    }
}
