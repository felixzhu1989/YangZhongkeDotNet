using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using StackExchange.Redis;

namespace WebApplicationConfig.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //在非Program中读取配置的一种方法
        private readonly IOptions<SmtpSettings> _options;
        private readonly IConnectionMultiplexer _multiplexer;
        public ValuesController(IOptions<SmtpSettings> options, IConnectionMultiplexer multiplexer)
        {
            _options = options;
            _multiplexer = multiplexer;
        }

        [HttpGet]
        public string Get()
        {
            var ping = _multiplexer.GetDatabase(0).Ping();//Ping一下，看活着吗
            return $"smtp:{_options.Value.ToString()}|Redis:{ping}";
        }
    }
}
