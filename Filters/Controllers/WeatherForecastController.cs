using Filters.Filters.ActionFilters;
using Microsoft.AspNetCore.Mvc;

namespace Filters.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [TypeFilter(typeof(WeatherActiinFilter), Arguments = new object[] { "controller-Key", "controller-Value" }, Order = 2)]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries =
        [
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        ];

        [HttpGet(Name = "GetWeatherForecast")]
        [TypeFilter(typeof(WeatherActiinFilter), Arguments = new object[] { "custom-Key", "Custom-Value" }, Order = 3)]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
