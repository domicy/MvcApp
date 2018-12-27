namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddService : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Activities", "Car_ID", "dbo.Cars");
            DropIndex("dbo.Activities", new[] { "Car_ID" });
            RenameColumn(table: "dbo.Activities", name: "Car_ID", newName: "CarId");
            DropPrimaryKey("dbo.Activities");
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Name = c.String(),
                        Address = c.String(),
                        Mobile = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Activities", "ServiceId", c => c.Int(nullable: false));
            AlterColumn("dbo.Activities", "ID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Activities", "CarId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Activities", "ID");
            CreateIndex("dbo.Activities", "CarId");
            CreateIndex("dbo.Activities", "ServiceId");
            AddForeignKey("dbo.Activities", "ServiceId", "dbo.Services", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Activities", "CarId", "dbo.Cars", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Activities", "CarId", "dbo.Cars");
            DropForeignKey("dbo.Activities", "ServiceId", "dbo.Services");
            DropIndex("dbo.Activities", new[] { "ServiceId" });
            DropIndex("dbo.Activities", new[] { "CarId" });
            DropPrimaryKey("dbo.Activities");
            AlterColumn("dbo.Activities", "CarId", c => c.Int());
            AlterColumn("dbo.Activities", "ID", c => c.Int(nullable: false));
            DropColumn("dbo.Activities", "ServiceId");
            DropTable("dbo.Services");
            AddPrimaryKey("dbo.Activities", "ID");
            RenameColumn(table: "dbo.Activities", name: "CarId", newName: "Car_ID");
            CreateIndex("dbo.Activities", "Car_ID");
            AddForeignKey("dbo.Activities", "Car_ID", "dbo.Cars", "ID");
        }
    }
}
