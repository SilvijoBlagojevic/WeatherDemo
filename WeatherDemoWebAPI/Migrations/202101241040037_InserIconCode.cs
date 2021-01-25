namespace WeatherDemoWebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InserIconCode : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE WeatherDatas SET IconCode = '13d' ");
        }
        
        public override void Down()
        {
        }
    }
}
