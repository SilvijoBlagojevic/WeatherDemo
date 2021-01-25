namespace WeatherDemoWebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangePropIconUrl2IconCode : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WeatherDatas", "IconCode", c => c.String());
            DropColumn("dbo.WeatherDatas", "IconUrl");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WeatherDatas", "IconUrl", c => c.String());
            DropColumn("dbo.WeatherDatas", "IconCode");
        }
    }
}
