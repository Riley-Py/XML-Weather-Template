using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        //list to hold day objects
        public static List<Day> days = new List<Day>();
        
        //value for when the time starts in the suntime/sunset values for substringing
        const int timeStart = 11;

        //Default city and country values whenever the program starts
        public static string city = "Stratford";
        public static string country = "CA";


        public Form1()
        {
            InitializeComponent();

            ExtractCurrent();
            ExtractForecast();


            ChangeScreen(this, new CurrentScreen());
        }

       
        /// <summary>
        /// scraps the current weather information from openweathermap.org
        /// </summary>
        public static void ExtractCurrent()     
        {
            //Creates a day for the current day and adds it to the list
            Day currentDay = new Day();
            days.Add(currentDay);

            //current info 
            XmlReader reader = XmlReader.Create($"http://api.openweathermap.org/data/2.5/weather?q={city},{country}&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");
            
            //Finds city/sunrise/sunset/temperatures/weather/humidity/ when it was last updated
            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            reader.ReadToFollowing("sun");
            days[0].sunrise = reader.GetAttribute("rise").Substring(timeStart);
            days[0].sunset = reader.GetAttribute("set").Substring(timeStart);

            reader.ReadToFollowing("temperature");
            days[0].currentTemp = reader.GetAttribute("value");
            days[0].tempHigh = reader.GetAttribute("max");
            days[0].tempLow = reader.GetAttribute("min");

            reader.ReadToFollowing("humidity");
            days[0].humidity = reader.GetAttribute("value");

            reader.ReadToFollowing("weather");
            days[0].condition = reader.GetAttribute("icon");

            reader.ReadToFollowing("lastupdate");
            days[0].lastUpdate = reader.GetAttribute("value");

            reader.Close();

        }
        /// <summary>
        /// Scraps the forecast data from openweathermap.org
        /// </summary>
        public static void ExtractForecast()
        {
            //Reads file for the forcast
            XmlReader reader = XmlReader.Create($"http://api.openweathermap.org/data/2.5/forecast/daily?q={city},{country}&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            while (reader.Read())
            {
                //Crates a new day each time the preivous day is done
                Day day = new Day();

                //Reads to the following time element
                reader.ReadToFollowing("time");

                //Checks if the day that it's on is today (as that was done in current forcast
                if (reader.GetAttribute("day") == Convert.ToString(DateTime.Today).Substring(0, 10))
                {
                    reader.Skip();

                }

                day.time = reader.GetAttribute("day");

                reader.ReadToFollowing("symbol");
                day.condition = reader.GetAttribute("var");

                reader.ReadToFollowing("temperature");
                day.currentTemp = reader.GetAttribute("day");
                day.tempLow = reader.GetAttribute("min");   
                day.tempHigh = reader.GetAttribute("max");

                days.Add(day);
                
            }
            reader.Close();

        }
        /// <summary>
        /// Changes the screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="next"></param>
        public static void ChangeScreen(object sender, UserControl next)
        {
            Form f; // will either be the sender or parent of sender

            if (sender is Form)
            {
                f = (Form)sender;
            }
            else
            {
                UserControl current = (UserControl)sender;
                f = current.FindForm();
                f.Controls.Remove(current);
            }

            next.Location = new Point((f.ClientSize.Width - next.Width) / 2,
                (f.ClientSize.Height - next.Height) / 2);

            f.Controls.Add(next);
            next.Focus();
        }
    }  
}
