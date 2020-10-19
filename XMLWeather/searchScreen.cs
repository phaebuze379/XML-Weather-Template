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

   
    public partial class searchScreen : UserControl
    {
        public searchScreen()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
             Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                string location = textBox1.Text;

                Form1.ExtractForecast(location);
                Form1.ExtractCurrent(location);



                Form f = this.FindForm();
                f.Controls.Remove(this);

                CurrentScreen cs = new CurrentScreen();
                f.Controls.Add(cs);
            }

            catch
            {
                label4.Text = "please input proper city";
            }
        }
    }
}
