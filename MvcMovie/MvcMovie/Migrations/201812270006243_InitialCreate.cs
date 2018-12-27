namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Description = c.String(),
                        Cost = c.Double(nullable: false),
                        Odometer = c.Int(nullable: false),
                        Car_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cars", t => t.Car_ID)
                .Index(t => t.Car_ID);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Vin = c.String(),
                        Make = c.String(),
                        Model = c.String(),
                        Year = c.Int(nullable: false),
                        Month = c.Int(),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        Genre = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Activities", "Car_ID", "dbo.Cars");
            DropIndex("dbo.Activities", new[] { "Car_ID" });
            DropTable("dbo.Movies");
            DropTable("dbo.Cars");
            DropTable("dbo.Activities");
        }
    }
}
