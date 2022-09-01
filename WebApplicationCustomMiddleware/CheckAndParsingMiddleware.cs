using Dynamic.Json;

namespace WebApplicationCustomMiddleware
{
    public class CheckAndParsingMiddleware
    {
        private readonly RequestDelegate _next;
        public CheckAndParsingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var pwd = context.Request.Query["password"];
            if (pwd == "123")
            {
                //判断请求是否为Json请求
                if (context.Request.HasJsonContentType())
                {
                    var reqStream = context.Request.BodyReader.AsStream(); //请求流
                    //Install-Package Dynamic.Json，讲Json反序列化为dynamic类型
                    context.Items["BodyJson"]=await DJson.ParseAsync(reqStream);
                }
                await _next(context);//执行下一个中间件
            }
            else
            {
                context.Response.StatusCode = 401;
            }
        }
    }
}
