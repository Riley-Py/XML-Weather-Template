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
            dateLabel.Text = $"Updated as of: {DateTime.Now.ToString("MMMM MM, yyy")}";

            //Temporary (make for loop for the other days
            switch (Form1.days[0].condition)
            {
                case "13d":
                    condition.Image = Properties.Resources.snow;
                    break;
                case "13n":
                    condition.Image = Properties.Resources.snow;
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
