using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApplicationFilter
{
    public class FirstActionFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            //next指向的是下一个筛选器，如果没有则是指向方法
            Console.WriteLine("FirstActionFilter 前代码");
            var result = await next();
            Console.WriteLine(result.Exception == null ? "FirstActionFilter执行成功" : "FirstActionFilter发生异常");
        }
    }
}
