using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace XMLWeather
{
    public partial class SearchScreen : UserControl
    {
        public SearchScreen()
        {
            InitializeComponent();
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new ForecastScreen());
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new CurrentScreen());
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //scraps the city and country data from the textboxes
            Form1.city = citySearchBox.Text;
            Form1.country = countrySearchBox.Text;

            #region trys to see if the input is valid; otherwise defaults to generic city and country
            try
            {
                Form1.days.Clear();

                Form1.ExtractCurrent();
                Form1.ExtractForecast();         

                Form1.ChangeScreen(this, new CurrentScreen());         

            }
            catch
            {
                errorLabel.Visible = true;

                citySearchBox.Clear();
                countrySearchBox.Clear();

                Form1.city = "Stratford";
                Form1.country = "CA";

                Form1.days.Clear();

                Form1.ExtractCurrent();
                Form1.ExtractForecast();


            }
            #endregion


        }
    }
}
