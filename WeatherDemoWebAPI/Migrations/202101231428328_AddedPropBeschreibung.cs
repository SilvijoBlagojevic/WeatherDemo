namespace WeatherDemoWebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPropBeschreibung : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WeatherDatas", "Beschreibung", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.WeatherDatas", "Beschreibung");
        }
    }
}
