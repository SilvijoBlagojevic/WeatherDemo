namespace WeatherDemoWebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WeatherDatas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Stadt = c.String(),
                        Temperatur = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Luftdruck = c.Int(nullable: false),
                        Feuchtigkeit = c.Int(nullable: false),
                        GerTemperatur = c.Decimal(nullable: false, precision: 18, scale: 2),
                        HoeTemperatur = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Windgeschwindigkeit = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Windrichtung = c.Int(nullable: false),
                        IconUrl = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WeatherDatas");
        }
    }
}
