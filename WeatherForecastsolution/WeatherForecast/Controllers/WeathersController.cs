using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeatherForecast.Models;

namespace WeatherForecast.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeathersController : ControllerBase
    {
        private readonly WeatherContext _context;

        public WeathersController(WeatherContext context)
        {
            _context = context;
        }

        // GET: api/Weathers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Weather>>> Getweathers()
        {
            return await _context.weathers.ToListAsync();
        }

        // GET: api/Weathers/5
        [HttpGet("{City}")]
        public async Task<ActionResult<Weather>> GetWeather(string City)
        {
            var weather = await _context.weathers.FindAsync();

            if (weather == null)
            {
                return NotFound();
            }

            return weather;
        }

        // PUT: api/Weathers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{City}")]
        public async Task<IActionResult> PutWeather(String city, Weather weather)
        {
            if (city != weather.City)
            {
                return BadRequest();
            }

            _context.Entry(weather).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WeatherExists(city))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Weathers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Weather>> PostWeather(Weather weather)
        {
            _context.weathers.Add(weather);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWeather", new { city = weather.City}, weather);
        }

        

        private bool WeatherExists(string city)
        {
            return _context.weathers.Any(e => e.City == city);
        }
    }
}
