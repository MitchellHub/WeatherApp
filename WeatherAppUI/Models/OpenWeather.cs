using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherAppUI.Models
{
    public class OpenWeather
    {
        private string _description;

        public int id { get; set; }
        public string main { get; set; }
        public string description {
            get => _description;
            set {
                // convert description to title caes
                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                _description = textInfo.ToTitleCase(value);
            }
        }
        public string icon { get; set; }
    }
}
