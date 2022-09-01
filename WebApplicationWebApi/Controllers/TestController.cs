using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using Zack.ASPNETCore;

namespace WebApplicationWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        //假数据
        List<Person> persons = new List<Person>(){ new Person(1, "zhf", true, DateTime.Now),
            new Person(2, "yzk", true, DateTime.Now),new Person(3, "zrf", true, DateTime.Now)
        };
        //假查询
        Task<Person?> GetByIdAsync(long id)
        {
            var result = persons.SingleOrDefault(p => p.Id == id);
            return Task.FromResult(result);
        }

        //依赖注入
        private readonly IMemoryCache _memoryCache;
        private readonly IMemoryCacheHelper _memoryHelper;
        private readonly IDistributedCache _distributed;
        private readonly IDistributedCacheHelper _distributedHelper;
        public TestController(IMemoryCache memoryCache, IMemoryCacheHelper memoryHelper, IDistributedCache distributed, IDistributedCacheHelper distributedHelper)
        {
            _memoryCache = memoryCache;
            _memoryHelper = memoryHelper;
            _distributed = distributed;
            _distributedHelper = distributedHelper;
        }

        [HttpGet]
        public async Task<ActionResult<Person?>> Get(long id)
        {

            //使用封装分布式缓存帮助中的GetOrCreateAsync
            var result = await _distributedHelper.GetOrCreateAsync($"Person{id}", async (e) =>
            {
                return await GetByIdAsync(id);
            }, 10);
            if (result == null) return NotFound($"找不到id={id}的人");
            else return result;

            /*//使用redis分布式缓存
            var str = await _distributed.GetStringAsync($"Person{id}");
            Person? result;
            if (str == null)
            {
                Console.WriteLine($"从数据库中读取{id}");
                result= await GetByIdAsync(id);
                await _distributed.SetStringAsync($"Person{id}", JsonSerializer.Serialize(result));
            }
            else
            {
                Console.WriteLine($"从缓存中读取{id}");
                result= JsonSerializer.Deserialize<Person?>(str);
            }
            if (result == null) return NotFound($"找不到id={id}的人");
            else return result;*/


            /*//使用封装内存缓存帮助中的GetOrCreateAsync
            var result = await _memoryHelper.GetOrCreateAsync($"Person{id}", async (e) =>
            {
                return await GetByIdAsync(id);
            }, 10);
            if (result == null) return NotFound($"找不到id={id}的人");
            else return result;*/

            /*//内存缓存
            Console.WriteLine($"开始查询GetByIdAsync，id={id}");
            //缓存的key得加上变量（和业务逻辑相关），"Person{id}"
            var result = await _memoryCache.GetOrCreateAsync($"Person{id}", async (e) =>
            {
                Console.WriteLine($"缓存里没找到，到数据库中查一查，id={id}");
                //e.AbsoluteExpirationRelativeToNow=TimeSpan.FromSeconds(10);//缓存有效期10秒
                //e.SlidingExpiration=TimeSpan.FromSeconds(10);//缓存有效期内，被访问就延续时间
                e.AbsoluteExpirationRelativeToNow=TimeSpan.FromSeconds(Random.Shared.Next(10,15));//随机过期时间，避免缓存雪崩
                //var person = await GetByIdAsync(id);
                //Console.WriteLine($"从数据库查询得结果是{(person==null ? "null":person)}");
                //return person;
                return await GetByIdAsync(id);
            });
            Console.WriteLine($"GetOrCreateAsync结果是{result}");
            if (result == null) return NotFound($"找不到id={id}的人");
            else return result;*/
        }

        [HttpPost]
        public string[] SaveNote(SaveNoteRequest request)
        {
            System.IO.File.WriteAllText($"{request.Title}.txt", request.Content);
            return new string[] { "OK", request.Title };
        }
    }
}
