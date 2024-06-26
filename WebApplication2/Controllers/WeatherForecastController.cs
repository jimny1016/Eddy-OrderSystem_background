using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
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

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet("GetWeatherForecast")]
        public HellowoldClass Get()
        {
            return new HellowoldClass() { Hey = "HelloWorld" };
        }

        [HttpGet("GetWeatherForecast2")]
        public HellowoldClass Get2(string ddd)
        {
            return new HellowoldClass() { Hey = "HelloWorld" };
        }
    }

    public class HellowoldClass
    {

        public string Hey { get; set; }
    }
}