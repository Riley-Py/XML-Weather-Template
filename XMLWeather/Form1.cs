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

        int timeStart = 11;


        public Form1()
        {
            InitializeComponent();

            ExtractForecast();
            ExtractCurrent();

            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        private void ExtractForecast()
        {


            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");





        }

        private void ExtractCurrent()
        {
            Day currentDay = new Day();
            days.Add(currentDay);

            // current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            //TODO: find the city and current temperature and add to appropriate item in days list

            

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


            reader.Close();




        }


    }
}
