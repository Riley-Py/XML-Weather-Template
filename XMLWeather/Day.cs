using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    public class Day
    {
        public string number, currentTemp, time, condition, location, tempHigh, tempLow, 
            windSpeed, windDirection, precipitation, visibility, humidity, sunrise, sunset, lastUpdate;

        public Day()
        {
            number = currentTemp = time = condition = location = tempHigh = tempLow
                = windSpeed = windDirection = precipitation = visibility = humidity = sunrise = sunset = lastUpdate = "";
        }
    }
}
