using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationFilter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public async Task<string> Get()
        {
            //读取一个不存在的文件，故意引发异常
            return await System.IO.File.ReadAllTextAsync("d:/1.txt");
        }
    }
}
