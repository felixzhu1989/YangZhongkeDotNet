using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationMediatR.Controllers
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
        //ע��IMediator����
        private readonly IMediator _mediator;
        private readonly MyDbContext _context;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,IMediator mediator, MyDbContext context)
        {
            _logger = logger;
            _mediator = mediator;
            _context = context;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task< IEnumerable<WeatherForecast>> Get()
        {
            //������Ϣ
            await _mediator.Publish(new PostNotification($"��ð�{DateTime.Now}"));
            //����û�����
            User u1 = new User("hongfeng");
            u1.ChangePassword("123456");
            u1.ChangeName("zhuhongfeng");
            _context.Users.Add(u1);
            await _context.SaveChangesAsync();




            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}