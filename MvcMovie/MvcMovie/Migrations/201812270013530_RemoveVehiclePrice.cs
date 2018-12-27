namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveVehiclePrice : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Cars", "Price");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cars", "Price", c => c.Double(nullable: false));
        }
    }
}
