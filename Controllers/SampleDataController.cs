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
        private readonly WeatherContext _context;

        public SampleDataController(WeatherContext context)
        {
            _context = context;
        }

        [HttpGet("[action]")]
        public async Task<IEnumerable<WeatherForecast>> WeatherForecasts()
        {
            return await _context.WeatherForecasts.ToListAsync();
        }
    }
}
