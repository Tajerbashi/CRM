namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ver1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ReminderUsers", "Reminder_ID", "dbo.Reminders");
            DropForeignKey("dbo.ReminderUsers", "User_ID", "dbo.Users");
            DropIndex("dbo.ReminderUsers", new[] { "Reminder_ID" });
            DropIndex("dbo.ReminderUsers", new[] { "User_ID" });
            AddColumn("dbo.Reminders", "Users_ID", c => c.Int());
            CreateIndex("dbo.Reminders", "Users_ID");
            AddForeignKey("dbo.Reminders", "Users_ID", "dbo.Users", "ID");
            DropTable("dbo.ReminderUsers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ReminderUsers",
                c => new
                    {
                        Reminder_ID = c.Int(nullable: false),
                        User_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Reminder_ID, t.User_ID });
            
            DropForeignKey("dbo.Reminders", "Users_ID", "dbo.Users");
            DropIndex("dbo.Reminders", new[] { "Users_ID" });
            DropColumn("dbo.Reminders", "Users_ID");
            CreateIndex("dbo.ReminderUsers", "User_ID");
            CreateIndex("dbo.ReminderUsers", "Reminder_ID");
            AddForeignKey("dbo.ReminderUsers", "User_ID", "dbo.Users", "ID", cascadeDelete: true);
            AddForeignKey("dbo.ReminderUsers", "Reminder_ID", "dbo.Reminders", "ID", cascadeDelete: true);
        }
    }
}
