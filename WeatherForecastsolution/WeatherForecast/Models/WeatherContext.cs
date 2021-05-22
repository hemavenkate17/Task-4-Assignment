using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WeatherForecast.Models
{
    public class WeatherContext : DbContext
    {
        public WeatherContext() : base()
        {

        }


        public WeatherContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Weather> weathers{ get; set; }
    
    }
}
