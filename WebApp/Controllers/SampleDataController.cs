using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreVueStarter.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private List<WeatherForecast> enumWeather = new List<WeatherForecast>();
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };


        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts()
        {

            var rng = new Random();
            enumWeather.Add(new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(enumWeather.Count).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
            enumWeather.Add(new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(enumWeather.Count).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
            var testEnum = enumWeather.Select(weatehr => weatehr);
            return testEnum;
        }

        public class WeatherForecast
        {
            public string DateFormatted { get; set; }
            public int TemperatureC { get; set; }
            public string Summary { get; set; }

            public int TemperatureF
            {
                get
                {
                    return 32 + (int)(TemperatureC / 0.5556);
                }
            }
        }
    }
}
