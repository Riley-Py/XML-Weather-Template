using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            cityOutput.Text = $"{Form1.days[0].location}";
            currentOutput.Text = $"{Math.Round(Convert.ToDecimal(Form1.days[0].currentTemp))}°";
            highTemp.Text = $"{Math.Round(Convert.ToDecimal(Form1.days[0].tempHigh))}°";
            lowTemp.Text = $"{Math.Round(Convert.ToDecimal(Form1.days[0].tempLow))}°";
            dateLabel.Text = $"Updated as of: {DateTime.Now.ToString("d")}";

            humidityMeasure.Value = int.Parse(Form1.days[0].humidity);
            humidityValue.Text = $"{Form1.days[0].humidity} %";



            //Temporary (make for loop for the other days)
            switch (Form1.days[0].condition)
            {
                case "13d":
                    condition.Image = Properties.Resources.snow;
                    break;
                case "13n":
                    condition.Image = Properties.Resources.snow;
                    break;
                case "02d":
                    condition.Image = Properties.Resources.partialClouds;
                    break;
                case "02n":
                    condition.Image = Properties.Resources.partialCloudsNight;
                    break;
                case "03d":
                    condition.Image = Properties.Resources.clouds;
                    break;
                case "03n":
                    condition.Image = Properties.Resources.clouds;
                    break;
                case "04d":
                    condition.Image = Properties.Resources.clouds;
                    break;
                case "04n":
                    condition.Image = Properties.Resources.clouds;
                    break;
                case "10d":
                    condition.Image = Properties.Resources.rainySun;
                    break;
                case "10n":
                    condition.Image = Properties.Resources.rainyNight;
                    break;
                case "11d":
                    condition.Image = Properties.Resources.thunderStorm;
                    break;
                case "11n":
                    condition.Image = Properties.Resources.thunderStorm;
                    break;
                case "50d":
                    condition.Image = Properties.Resources.mist;
                    break;
                case "50n":
                    condition.Image = Properties.Resources.mist;
                    break;



            }

        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }
    }
}
