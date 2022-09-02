using WebApplicationCustomMiddleware.MiniWebApi;

namespace WebApplicationCustomMiddleware
{
    public class MyActionFilter : IMyActionFilter
    {
        public void Execute()
        {
            Console.WriteLine("Filter 执行啦");
        }
    }
}
