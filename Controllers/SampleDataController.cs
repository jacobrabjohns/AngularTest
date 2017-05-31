using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace AngularTest.Controllers
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
        public async Task<IActionResult> WeatherForecasts()
        {
            return Ok(await _weatherSevice.GetForecasts());
        }
    }
}
