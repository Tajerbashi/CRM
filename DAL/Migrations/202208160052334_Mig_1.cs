namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig_1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Activities", "DeleteStatus", c => c.Boolean(nullable: false));
            AddColumn("dbo.ActivityCategories", "DeleteStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ActivityCategories", "DeleteStatus");
            DropColumn("dbo.Activities", "DeleteStatus");
        }
    }
}
