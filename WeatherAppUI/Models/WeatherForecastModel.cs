using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    // sydney woeid 1105779
    public class WeatherForecastModel
    {
        public DayForeCastModel[] Consolidated_weather { get; set; }
        public DateTime Time { get; set; }
        public DateTime Sun_rise { get; set; }
        public DateTime Sun_set { get; set; }
        public string Title { get; set; }
        public string Timezone { get; set; }
    }
}
