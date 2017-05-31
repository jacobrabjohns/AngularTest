using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationBasic.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private readonly IWeatherSevice _weatherSevice;

        public SampleDataController(IWeatherSevice weatherSevice)
        {
            _weatherSevice = weatherSevice;
        }

        [HttpGet("[action]")]
        public async Task<IEnumerable<WeatherForecast>> WeatherForecasts()
        {
            return await _weatherSevice.GetForecasts();
        }
    }
}
