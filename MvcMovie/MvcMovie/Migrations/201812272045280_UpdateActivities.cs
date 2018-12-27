namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateActivities : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Activities");
            AlterColumn("dbo.Activities", "ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Cars", "Make", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Activities", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Activities");
            AlterColumn("dbo.Cars", "Make", c => c.String());
            AlterColumn("dbo.Activities", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Activities", "ID");
        }
    }
}
