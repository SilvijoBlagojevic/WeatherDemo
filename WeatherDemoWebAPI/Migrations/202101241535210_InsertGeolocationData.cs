namespace WeatherDemoWebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertGeolocationData : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE WeatherDatas SET Latitude = 50.9848, Longitude=11.0299 WHERE Stadt='Erfurt' ");
            Sql("UPDATE WeatherDatas SET Latitude = 52.5192, Longitude=13.4061  WHERE Stadt='Berlin' ");
            Sql("UPDATE WeatherDatas SET Latitude = 50.1109, Longitude=8.6821  WHERE Stadt='Frankfurt'");
            Sql("UPDATE WeatherDatas SET Latitude = 52.3941, Longitude=13.0727 WHERE Stadt='Potsdam'");
            Sql("UPDATE WeatherDatas SET Latitude = 50.7347, Longitude=7.0982 WHERE Stadt='Bonn'");
            Sql("UPDATE WeatherDatas SET Latitude = 50.9800, Longitude=11.060 WHERE Stadt='Weimar'");
            Sql("UPDATE WeatherDatas SET Latitude = 51.3397, Longitude=12.3731 WHERE Stadt='Leipzig'");
            Sql("UPDATE WeatherDatas SET Latitude = 53.5511, Longitude=9.9937 WHERE Stadt='Hamburg'");
            Sql("UPDATE WeatherDatas SET Latitude = 51.0504, Longitude=13.7373 WHERE Stadt='Dresden'");
            Sql("UPDATE WeatherDatas SET Latitude = 53.3759, Longitude=9.732 WHERE Stadt='Hanover'");
        }
        
        public override void Down()
        {
        }
    }
}
