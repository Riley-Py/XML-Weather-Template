using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            //Makes a list of all of the controls needed
            List<PictureBox> conditions = new List<PictureBox> { day2Condition, day3Condition, day4Condition, day5Condition, day6Condition, day7Condition };

            List<Label> dayDisplay = new List<Label> { day2Label, day3Label, day4Label, day5Label, day6Label, day7Label };
            List<Label> currentExpectedTemps = new List<Label> { expected2Label, expected3Label, expected4Label, expected5Label, expected6Label, expected7Label };
            List<Label> highExpectedTemps = new List<Label> { high2, high3, high4, high5, high6, high7 };
            List<Label> lowExpectedTemps = new List<Label> { low2, low3, low4, low5, low6, low7 };

            int weatherBackgroundValue = int.Parse(Form1.days[4].number);

            #region puts all of the information form the days list into the appropiate control
            for (int e = 1; e < 7; e++)
            {
                //Uses e - 1 as when the index of days is 1 (to avoid using the current day), the other lists are at index 0
                dayDisplay[e - 1].Text = DateTime.Parse(Form1.days[e].time).ToString("dddd");
                currentExpectedTemps[e - 1].Text = $"{Math.Round(Convert.ToDecimal(Form1.days[e].currentTemp))}°";
                lowExpectedTemps[e - 1].Text = $"{Math.Round(Convert.ToDecimal(Form1.days[e].tempLow))}°";
                highExpectedTemps[e - 1].Text = $"{Math.Round(Convert.ToDecimal(Form1.days[e].tempHigh))}°";

                //For all of the images
                switch (Form1.days[e].condition)
                {
                    case "13d":
                        conditions[e - 1].Image = Properties.Resources.snow;
                        break;
                    case "13n":
                        conditions[e - 1].Image = Properties.Resources.snow;
                        break;
                    case "02d":
                        conditions[e - 1].Image = Properties.Resources.partialClouds;
                        break;
                    case "02n":
                        conditions[e - 1].Image = Properties.Resources.partialCloudsNight;
                        break;
                    case "03d":
                        conditions[e - 1].Image = Properties.Resources.clouds;
                        break;
                    case "03n":
                        conditions[e - 1].Image = Properties.Resources.clouds;
                        break;
                    case "04d":
                        conditions[e - 1].Image = Properties.Resources.clouds;
                        break;
                    case "04n":
                        conditions[e - 1].Image = Properties.Resources.clouds;
                        break;
                    case "10d":
                        conditions[e - 1].Image = Properties.Resources.rainySun;
                        break;
                    case "10n":
                        conditions[e - 1].Image = Properties.Resources.rainyNight;
                        break;
                    case "11d":
                        conditions[e - 1].Image = Properties.Resources.thunderStorm;
                        break;
                    case "11n":
                        conditions[e - 1].Image = Properties.Resources.thunderStorm;
                        break;
                    case "50d":
                        conditions[e - 1].Image = Properties.Resources.mist;
                        break;
                    case "50n":
                        conditions[e - 1].Image = Properties.Resources.mist;
                        break;
                    case "01d":
                        conditions[e - 1].Image = Properties.Resources.sunny;
                        break;
                    case "01n":
                        conditions[e - 1].Image = Properties.Resources.moon;
                        break;
                }
                if (weatherBackgroundValue < 300)
                {
                    this.BackgroundImage = Properties.Resources.thunderstormBackground;
                }
                else if (weatherBackgroundValue < 500 && weatherBackgroundValue > 300)
                {
                    this.BackgroundImage = Properties.Resources.drizzleBackground;
                }
                else if (weatherBackgroundValue > 500 && weatherBackgroundValue < 600)
                {
                    this.BackgroundImage = Properties.Resources.rainBackground;
                }
                else if (weatherBackgroundValue > 600 && weatherBackgroundValue < 800)
                {
                    this.BackgroundImage = Properties.Resources.snowBackground;
                }
                else
                {
                    this.BackgroundImage = Properties.Resources.cloudBackground;
                }

            }
            #endregion

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new CurrentScreen());
        }

        private void searchLabel_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new SearchScreen());
        }
    }
}
