using Microsoft.AspNetCore.Cors;
using System.Linq;
using System.Web.Http;
using WeatherDemoWebAPI.Context;
using WeatherDemoWebAPI.Models;

namespace WeatherDemoWebAPI.Controllers
{
    public class WeatherController : ApiController
    {
        [HttpGet] 
        public IHttpActionResult GetWeatherCityName(string city)
        {
            WeatherData weatherData;

            using (WeatherContext db = new WeatherContext())
            {
                weatherData = db.WeatherData.FirstOrDefault(x => x.Stadt == city);
            }

            if (weatherData == null) return NotFound();

            var formatedData = _FormatData(weatherData);

            return Ok(formatedData);
        }

        [HttpGet]
        public IHttpActionResult GetWeatherGeo(float latitude,float longitude)
        {
            WeatherData closestWeatherData;

            using (WeatherContext db = new WeatherContext())
            {
                closestWeatherData = db.WeatherData.OrderBy(x =>
                   (latitude - x.Latitude) * (latitude - x.Latitude) + (longitude - x.Longitude) * (longitude - x.Longitude))
                 .FirstOrDefault();                
            }

            if (closestWeatherData == null) return NotFound();

            var formatedData = _FormatData(closestWeatherData);

            return Ok(formatedData);
        }


        private object _FormatData(WeatherData weatherData)
        {
            return new
            {
                main = new { temp = weatherData.Temperatur, pressure = weatherData.Luftdruck, humidity = weatherData.Feuchtigkeit, temp_min = weatherData.GerTemperatur, temp_max = weatherData.HoeTemperatur },
                wind = new { speed = weatherData.Windgeschwindigkeit, deg = weatherData.Windrichtung },
                weather = new[] { new { description = weatherData.Beschreibung, icon = weatherData.IconCode } },
                name =  weatherData.Stadt
            };
        }
    }

   
}
