using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherForecast.Models
{
    public class Weather
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string City { get; set; }
        public int highTemp { get; set; }
        public int lowTemp { get; set; }
        public string Forecast { get; set; }
    }
}
