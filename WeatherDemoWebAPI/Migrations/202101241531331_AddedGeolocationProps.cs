namespace WeatherDemoWebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGeolocationProps : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WeatherDatas", "Latitude", c => c.Single(nullable: false));
            AddColumn("dbo.WeatherDatas", "Longitude", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.WeatherDatas", "Longitude");
            DropColumn("dbo.WeatherDatas", "Latitude");
        }
    }
}
