using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WeatherDemoWebAPI.Models;

namespace WeatherDemoWebAPI.Context
{
    public class WeatherContext : DbContext
    {
        public WeatherContext() : base()
        {

        }

        public DbSet<WeatherData> WeatherData { get; set; }
    }
}