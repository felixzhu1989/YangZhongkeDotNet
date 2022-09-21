using Microsoft.AspNetCore.Mvc;
using Zack.EventBus;

namespace WebApplicationRabbitMQSender.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IEventBus _eventBus;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,IEventBus eventBus)
        {
            _logger = logger;
            _eventBus = eventBus;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            var order = new OrderData(1, "Hello", DateTime.Now);
            //发送集成事件消息
            _eventBus.Publish("OrderCreated",order);//order会被json序列化



            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }

    record OrderData(int Id, string Name, DateTime Date);
}