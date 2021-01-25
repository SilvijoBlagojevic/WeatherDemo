using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherDemoWebAPI.Models
{
    public class WeatherData
    {
        public int ID { get; set; }
        public string Stadt { get; set; }
        public decimal Temperatur { get; set; }
        public int Luftdruck { get; set; }
        public int Feuchtigkeit { get; set; }
        public decimal GerTemperatur { get; set; }
        public decimal HoeTemperatur { get; set; }
        public decimal Windgeschwindigkeit { get; set; }
        public int Windrichtung { get; set; }         
        public string IconCode { get; set; }
        public string Beschreibung { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }

    }
}