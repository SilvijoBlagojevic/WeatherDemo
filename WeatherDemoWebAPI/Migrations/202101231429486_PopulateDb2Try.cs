namespace WeatherDemoWebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDb2Try : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO WeatherDatas (Stadt, Temperatur, Luftdruck, Feuchtigkeit, GerTemperatur, HoeTemperatur, Windgeschwindigkeit, Windrichtung, IconUrl, Beschreibung)" +
                "VALUES ('Erfurt', 3, 997, 95, 2, 4, 5, 200, 'http://openweathermap.org/img/wn/13n@2x.png', 'maßiger Schnee' )");

            Sql("INSERT INTO WeatherDatas (Stadt, Temperatur, Luftdruck, Feuchtigkeit, GerTemperatur, HoeTemperatur, Windgeschwindigkeit, Windrichtung, IconUrl, Beschreibung)" +
                "VALUES ('Berlin', 4, 999, 93, 1, 2, 3, 199, 'http://openweathermap.org/img/wn/13n@2x.png', 'Schnee') ");

            Sql("INSERT INTO WeatherDatas (Stadt, Temperatur, Luftdruck, Feuchtigkeit, GerTemperatur, HoeTemperatur, Windgeschwindigkeit, Windrichtung, IconUrl, Beschreibung)" +
                 "VALUES ('Frankfurt', 2, 988, 91, 0, 4, 5, 201, 'http://openweathermap.org/img/wn/13n@2x.png', 'leichter Schnee') ");

            Sql("INSERT INTO WeatherDatas (Stadt, Temperatur, Luftdruck, Feuchtigkeit, GerTemperatur, HoeTemperatur, Windgeschwindigkeit, Windrichtung, IconUrl, Beschreibung)" +
                 "VALUES ('Potsdam', 0, 978, 97, 0, 2, 4, 255, 'http://openweathermap.org/img/wn/13n@2x.png', 'maßiger Schnee') ");

            Sql("INSERT INTO WeatherDatas (Stadt, Temperatur, Luftdruck, Feuchtigkeit, GerTemperatur, HoeTemperatur, Windgeschwindigkeit, Windrichtung, IconUrl, Beschreibung)" +
                  "VALUES ('Bonn', -3, 978, 99, -3, 4, 4, 155, 'http://openweathermap.org/img/wn/13n@2x.png', 'maßiger Schnee' )");

            Sql("INSERT INTO WeatherDatas (Stadt, Temperatur, Luftdruck, Feuchtigkeit, GerTemperatur, HoeTemperatur, Windgeschwindigkeit, Windrichtung, IconUrl, Beschreibung)" +
              "VALUES ('Weimar', -1, 978, 91, 0, -2, 4, 255, 'http://openweathermap.org/img/wn/13n@2x.png', 'leichter Schnee') ");

            Sql("INSERT INTO WeatherDatas (Stadt, Temperatur, Luftdruck, Feuchtigkeit, GerTemperatur, HoeTemperatur, Windgeschwindigkeit, Windrichtung, IconUrl, Beschreibung)" +
              "VALUES ('Leipzig', 0, 978, 97, 0, 2, 4, 255, 'http://openweathermap.org/img/wn/13n@2x.png','Schnee') ");

            Sql("INSERT INTO WeatherDatas (Stadt, Temperatur, Luftdruck, Feuchtigkeit, GerTemperatur, HoeTemperatur, Windgeschwindigkeit, Windrichtung, IconUrl, Beschreibung)" +
                 "VALUES ('Hamburg', 4, 978, 97, 0, 2, 4, 255, 'http://openweathermap.org/img/wn/13n@2x.png', 'Schnee') ");

            Sql("INSERT INTO WeatherDatas (Stadt, Temperatur, Luftdruck, Feuchtigkeit, GerTemperatur, HoeTemperatur, Windgeschwindigkeit, Windrichtung, IconUrl, Beschreibung)" +
                 "VALUES ('Dresden', 0, 978, 97, 0, 2, 4, 255, 'http://openweathermap.org/img/wn/13n@2x.png', 'Schnee' )");

            Sql("INSERT INTO WeatherDatas (Stadt, Temperatur, Luftdruck, Feuchtigkeit, GerTemperatur, HoeTemperatur, Windgeschwindigkeit, Windrichtung, IconUrl, Beschreibung)" +
                 "VALUES ('Hanover', 4, 978, 97, 0, 2, 4, 255, 'http://openweathermap.org/img/wn/13n@2x.png', 'leichter Schnee'  )");
        }
        
        public override void Down()
        {
        }
    }
}
