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
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }


        

        public void displayForecast()
        {
            label1.Text = Form1.days[0].location;

            int iconNumber1 = Convert.ToInt32(Form1.days[1].icon);
            date1.Text = Form1.days[1].date;
            double tempHigh = Convert.ToDouble(Form1.days[1].tempLow);
            min.Text = Math.Round(tempHigh) + "°C"; 
            double tempLow = Convert.ToDouble(Form1.days[1].tempHigh);
            max.Text = Math.Round(tempLow) + "°C"; 
            if (iconNumber1 >= 200 && iconNumber1 < 233)
            {
                pictureBox1.BackgroundImage = Properties.Resources.thunderstorm;
            }

            if (iconNumber1 >= 300 && iconNumber1 < 532)
            {
                pictureBox1.BackgroundImage = Properties.Resources.rain;
            }

            if (iconNumber1 >= 600 && iconNumber1 < 700)
            {
                pictureBox1.BackgroundImage = Properties.Resources.snow;
            }

            if (iconNumber1 == 800)
            {
                pictureBox1.BackgroundImage = Properties.Resources.sun;
            }

            if (iconNumber1 == 801 || iconNumber1 == 802)
            {
                pictureBox1.BackgroundImage = Properties.Resources.sun_with_clouds;
            }

            if (iconNumber1 == 803 || iconNumber1 == 804)
            {
                pictureBox1.BackgroundImage = Properties.Resources.clouds;
            }

            int iconNumber2 = Convert.ToInt32(Form1.days[2].icon);
            date2.Text = Form1.days[2].date;
            double tempHigh2 = Convert.ToDouble(Form1.days[2].tempLow);
            min2.Text = Math.Round(tempHigh2) + "°C"; 
            double tempLow2 = Convert.ToDouble(Form1.days[2].tempHigh);
            max2.Text = Math.Round(tempLow2) + "°C"; 
            if (iconNumber2 >= 200 && iconNumber2 < 233)
            {
                pictureBox2.BackgroundImage = Properties.Resources.thunderstorm;
            }

            if (iconNumber2 >= 300 && iconNumber2 < 532)
            {
                pictureBox2.BackgroundImage = Properties.Resources.rain;
            }

            if (iconNumber2 >= 600 && iconNumber2 < 700)
            {
                pictureBox2.BackgroundImage = Properties.Resources.snow;
            }

            if (iconNumber2 == 800)
            {
                pictureBox2.BackgroundImage = Properties.Resources.sun;
            }

            if (iconNumber2 == 801 || iconNumber2 == 802)
            {
                pictureBox2.BackgroundImage = Properties.Resources.sun_with_clouds;
            }

            if (iconNumber2 == 803 || iconNumber2 == 804)
            {
                pictureBox2.BackgroundImage = Properties.Resources.clouds;
            }

            int iconNumber3 = Convert.ToInt32(Form1.days[3].icon);
            date3.Text = Form1.days[3].date;
            double tempHigh3 = Convert.ToDouble(Form1.days[3].tempLow);
            min3.Text = Math.Round(tempHigh3) + "°C";
            double tempLow3 = Convert.ToDouble(Form1.days[3].tempHigh);
            max3.Text = Math.Round(tempLow3) + "°C";
            if (iconNumber3 >= 200 && iconNumber3 < 233)
            {
                pictureBox3.BackgroundImage = Properties.Resources.thunderstorm;
            }

            if (iconNumber3 >= 300 && iconNumber3 < 532)
            {
                pictureBox3.BackgroundImage = Properties.Resources.rain;
            }

            if (iconNumber3 >= 600 && iconNumber3 < 700)
            {
                pictureBox3.BackgroundImage = Properties.Resources.snow;
            }

            if (iconNumber3 == 800)
            {
                pictureBox3.BackgroundImage = Properties.Resources.sun;
            }

            if (iconNumber3 == 801 || iconNumber3 == 802)
            {
                pictureBox3.BackgroundImage = Properties.Resources.sun_with_clouds;
            }

            if (iconNumber3 == 803 || iconNumber3 == 804)
            {
                pictureBox3.BackgroundImage = Properties.Resources.clouds;
            }

            int iconNumber4 = Convert.ToInt32(Form1.days[4].icon);
            date4.Text = Form1.days[4].date;
            double tempHigh4 = Convert.ToDouble(Form1.days[4].tempLow);
            min4.Text = Math.Round(tempHigh4) + "°C";
            double tempLow4 = Convert.ToDouble(Form1.days[4].tempHigh);
            max4.Text = Math.Round(tempLow4) + "°C";
            if (iconNumber4 >= 200 && iconNumber4 < 233)
            {
                pictureBox4.BackgroundImage = Properties.Resources.thunderstorm;
            }

            if (iconNumber4 >= 300 && iconNumber4 < 532)
            {
                pictureBox4.BackgroundImage = Properties.Resources.rain;
            }

            if (iconNumber4 >= 600 && iconNumber4 < 700)
            {
                pictureBox4.BackgroundImage = Properties.Resources.snow;
            }

            if (iconNumber4 == 800)
            {
                pictureBox4.BackgroundImage = Properties.Resources.sun;
            }

            if (iconNumber4 == 801 || iconNumber4 == 802)
            {
                pictureBox4.BackgroundImage = Properties.Resources.sun_with_clouds;
            }

            if (iconNumber4 == 803 || iconNumber4 == 804)
            {
                pictureBox4.BackgroundImage = Properties.Resources.clouds;
            }

            int iconNumber5 = Convert.ToInt32(Form1.days[5].icon);
            date5.Text = Form1.days[5].date;
            double tempHigh5 = Convert.ToDouble(Form1.days[5].tempLow);
            min5.Text = Math.Round(tempHigh5) + "°C";
            double tempLow5 = Convert.ToDouble(Form1.days[5].tempHigh);
            max5.Text = Math.Round(tempLow5) + "°C";
            if (iconNumber5 >= 200 && iconNumber5 < 233)
            {
                pictureBox5.BackgroundImage = Properties.Resources.thunderstorm;
            }

            if (iconNumber5 >= 300 && iconNumber5 < 532)
            {
                pictureBox5.BackgroundImage = Properties.Resources.rain;
            }

            if (iconNumber5 >= 600 && iconNumber5 < 700)
            {
                pictureBox5.BackgroundImage = Properties.Resources.snow;
            }

            if (iconNumber5 == 800)
            {
                pictureBox5.BackgroundImage = Properties.Resources.sun;
            }

            if (iconNumber5 == 801 || iconNumber5 == 802)
            {
                pictureBox5.BackgroundImage = Properties.Resources.sun_with_clouds;
            }

            if (iconNumber5 == 803 || iconNumber5 == 804)
            {
                pictureBox5.BackgroundImage = Properties.Resources.clouds;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            searchScreen ss = new searchScreen();
            f.Controls.Add(ss);
        }
    }
}
