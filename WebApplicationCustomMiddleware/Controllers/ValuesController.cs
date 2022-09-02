

using Microsoft.Extensions.Caching.Memory;
using WebApplicationCustomMiddleware.Model;

namespace WebApplicationCustomMiddleware.Controllers
{
    public class ValuesController
    {
        private IMemoryCache memoryCache;
        public ValuesController(IMemoryCache memoryCache)
        {
            this.memoryCache = memoryCache;
        }
        public Person IncAge(Person p)
        {
            p.Age++;
            return p;
        }
        public object[] Get2(HttpContext ctx)
        {
            DateTime now = memoryCache.GetOrCreate("Now", e => DateTime.Now);
            string name = ctx.Request.Query["name"];
            return new object[] { "hello" + name, now };
        }
    }
}
