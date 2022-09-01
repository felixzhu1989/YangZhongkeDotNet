using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApplicationFilter
{
    public class MyExceptionFilter: IAsyncExceptionFilter
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        
        public MyExceptionFilter(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        //当系统中发生异常时，调用该方法
        public Task OnExceptionAsync(ExceptionContext context)
        {
            //context.Exception代表异常信息对象
            //context.ExceptionHandled赋值未true，则其他的ExceptionFilter不会再被执行
            //context.Result的值会被输出给客户端
            var message = _webHostEnvironment.IsDevelopment() ? context.Exception.ToString() : "服务器端发生异常";
            context.Result = new ObjectResult(new { Code = 500, Message = message });
            context.ExceptionHandled = true;
            return Task.CompletedTask;
        }
    }
}
