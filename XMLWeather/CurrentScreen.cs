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
            cityOutput.Text = Form1.days[0].location;
            dateOutput.Text = Convert.ToDateTime(Form1.days[0].date).ToString("ddd dd MMM yy");

            currentOutput.Text = Convert.ToDouble(Form1.days[0].currentTemp).ToString("0.") + "°c";

            minOutput.Text = Convert.ToDouble(Form1.days[0].tempLow).ToString("0.") + "°";
            maxOutput.Text = Convert.ToDouble(Form1.days[0].tempHigh).ToString("0.") + "°";

            conditionOutput.Text = Form1.days[0].condition;

            if (Convert.ToDouble(Form1.days[0].conditionNum) >= 200 && Convert.ToDouble(Form1.days[0].conditionNum) <= 299)
            {
                conditionBox.BackgroundImage = Properties.Resources.storm;
            }
            else if (Convert.ToDouble(Form1.days[0].conditionNum) >= 300 && Convert.ToDouble(Form1.days[0].conditionNum) <= 599)
            {
                conditionBox.BackgroundImage = Properties.Resources.rain;
            }
            else if (Convert.ToDouble(Form1.days[0].conditionNum) >= 600 && Convert.ToDouble(Form1.days[0].conditionNum) <= 699)
            {
                conditionBox.BackgroundImage = Properties.Resources.snow;
            }
            else if (Convert.ToDouble(Form1.days[0].conditionNum) >= 801 && Convert.ToDouble(Form1.days[0].conditionNum) <= 809)
            {
                conditionBox.BackgroundImage = Properties.Resources.cloud;
            }
            else if (Convert.ToDouble(Form1.days[0].conditionNum) == 800)
            {
                conditionBox.BackgroundImage = Properties.Resources.sun;
            }

            day1Output.Text = DateTime.Now.AddDays(1).ToString("ddd");
            day2Output.Text = DateTime.Now.AddDays(2).ToString("ddd");
            day3Output.Text = DateTime.Now.AddDays(3).ToString("ddd");

            day1Min.Text = Convert.ToDouble(Form1.days[1].tempLow).ToString("0.") + "°";
            day1Max.Text = Convert.ToDouble(Form1.days[1].tempHigh).ToString("0.") + "°";
            day2Min.Text = Convert.ToDouble(Form1.days[2].tempLow).ToString("0.") + "°";
            day2Max.Text = Convert.ToDouble(Form1.days[2].tempHigh).ToString("0.") + "°";
            day3Min.Text = Convert.ToDouble(Form1.days[3].tempLow).ToString("0.") + "°";
            day3Max.Text = Convert.ToDouble(Form1.days[3].tempHigh).ToString("0.") + "°";

            day1Con.Text = Form1.days[1].condition;
            day2Con.Text = Form1.days[2].condition;
            day3Con.Text = Form1.days[3].condition;
        }

    }
}
