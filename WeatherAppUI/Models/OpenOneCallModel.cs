using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherAppUI.Models
{

    public class OpenOneCallModel
    {
        public float lat { get; set; }
        public float lon { get; set; }
        public string timezone { get; set; }
        public int timezone_offset { get; set; }
        public OpenCurrentDataModel current { get; set; }
        public OpenHourlyDataModel[] hourly { get; set; }
        public OpenDailyDataModel[] daily { get; set; }
    }

    public class Rain
    {
        public float _1h { get; set; }
    }
}
