using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherAppUI.Models
{
    public class OpenDailyDataModel
    {
        public int dt { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
        public OpenFailyTemp_Range temp { get; set; }
        public OpenDailyFeels_Like feels_like { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }
        public float dew_point { get; set; }
        public float wind_speed { get; set; }
        public int wind_deg { get; set; }
        public OpenWeather[] weather { get; set; }
        public int clouds { get; set; }
        public float pop { get; set; }
        public float rain { get; set; }
        public float uvi { get; set; }
    }

    public class OpenFailyTemp_Range
    {
        public float day { get; set; }
        public float min { get; set; }
        public float max { get; set; }
        public float night { get; set; }
        public float eve { get; set; }
        public float morn { get; set; }
    }

    public class OpenDailyFeels_Like
    {
        public float day { get; set; }
        public float night { get; set; }
        public float eve { get; set; }
        public float morn { get; set; }
    }
}
