using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationConfig.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IWebHostEnvironment webEnv;

        public TestController(IWebHostEnvironment webEnv)
        {
            this.webEnv = webEnv;
        }

        [HttpGet]
        public string Get()
        {
           return webEnv.EnvironmentName;
            //return Environment.GetEnvironmentVariable("TEMP");//读取环境变量的值
        }
    }
}
