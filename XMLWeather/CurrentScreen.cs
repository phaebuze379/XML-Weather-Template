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
            
            dateLabel.Text = DateTime.Now.ToString("MM-dd-yyyy");

            cityOutput.Text = Form1.days[0].location;
            
            minLabel.Text = Convert.ToDouble(Form1.days[0].tempLow).ToString("0") + "°C";            
            maxLabel.Text = Convert.ToDouble(Form1.days[0].tempHigh).ToString("0") + "°C";            
            tempLabel.Text = Convert.ToDouble(Form1.days[0].currentTemp).ToString("0") + "°C";

            int iconNumber = Convert.ToInt32(Form1.days[0].icon);

            if (iconNumber >= 200 && iconNumber < 233)
            {
                pictureBox1.BackgroundImage = Properties.Resources.thunderstorm;
                BackColor = Color.CadetBlue;
            }

            if (iconNumber >= 300 && iconNumber < 532)
            {
                pictureBox1.BackgroundImage = Properties.Resources.rain;
                BackColor = Color.LightSkyBlue;
            }

            if (iconNumber >= 600 && iconNumber < 700)
            {
                pictureBox1.BackgroundImage = Properties.Resources.snow;
                BackColor = Color.LightGray;
            }

            if (iconNumber == 800)
            {
                pictureBox1.BackgroundImage = Properties.Resources.sun;
                BackColor = Color.LightGoldenrodYellow;
            }

            if (iconNumber == 801 || iconNumber == 802)
            {
                pictureBox1.BackgroundImage = Properties.Resources.sun_with_clouds;
                BackColor = Color.LightYellow;
            }

            if (iconNumber == 803 || iconNumber == 804)
            {
                pictureBox1.BackgroundImage = Properties.Resources.clouds;
                BackColor = Color.LightSlateGray;
            }
            conditionLabel.Text = Form1.days[0].condition;
            
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            searchScreen ss = new searchScreen();
            f.Controls.Add(ss);
        }

        
    }
}
