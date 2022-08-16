namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig_11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Activities", "ReminderDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Activities", "ReminderClock", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Activities", "ReminderClock");
            DropColumn("dbo.Activities", "ReminderDate");
        }
    }
}
