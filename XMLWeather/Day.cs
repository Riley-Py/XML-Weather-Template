using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    public class Day
    {
        public string date, currentTemp, time, condition, location, tempHigh, tempLow, 
            windSpeed, windDirection, precipitation, visibility, humidity, sunrise, sunset, lastUpdate;

        public Day()
        {
            date = currentTemp = time = condition = location = tempHigh = tempLow
                = windSpeed = windDirection = precipitation = visibility = humidity = sunrise = sunset = lastUpdate = "";
        }
    }
}
