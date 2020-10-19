﻿using System;
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
        
        // TODO: create list to hold day objects
        public static List<Day> days = new List<Day>();
        public static int visibility;

        public Form1()
        {
            InitializeComponent();

            ExtractForecast("stratford, CA");
            ExtractCurrent("stratford, CA");
            
            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        public static void ExtractForecast(string city)
        {
            days.Clear();
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=" + city + 
                "&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            while (reader.Read())
            {
                //create a day object
                Day d = new Day();

                //fill day object with required data
              
                reader.ReadToFollowing("time");
                d.date = reader.GetAttribute("day");

                reader.ReadToFollowing("symbol");
                d.icon = reader.GetAttribute("number");

                reader.ReadToFollowing("temperature");
                d.tempLow = reader.GetAttribute("min");
                d.tempHigh = reader.GetAttribute("max");

                //if day object not null | add to the days list
                days.Add(d);

            }
         }

        public static void ExtractCurrent(string city)
        {
            // current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=" + city + 
                ",CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");


            //find the city and current temperature and add to appropriate item in days list
            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            reader.ReadToFollowing("temperature");
            days[0].currentTemp = reader.GetAttribute("value");

            reader.ReadToFollowing("weather");
            days[0].icon = reader.GetAttribute("number");
            days[0].condition = reader.GetAttribute("value");


           
            

        }


    }
}
