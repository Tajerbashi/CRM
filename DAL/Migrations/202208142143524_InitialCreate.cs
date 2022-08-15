namespace DAL.Migrations
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
                        Title = c.String(),
                        Info = c.String(),
                        RegDate = c.DateTime(nullable: false),
                        ActivityCategory_ID = c.Int(),
                        customer_ID = c.Int(),
                        user_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ActivityCategories", t => t.ActivityCategory_ID)
                .ForeignKey("dbo.Customers", t => t.customer_ID)
                .ForeignKey("dbo.Users", t => t.user_ID)
                .Index(t => t.ActivityCategory_ID)
                .Index(t => t.customer_ID)
                .Index(t => t.user_ID);
            
            CreateTable(
                "dbo.ActivityCategories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Phone = c.String(),
                        RegDate = c.DateTime(nullable: false),
                        DeleteStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.InVoices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        InvoiceNumber = c.String(),
                        RegDate = c.DateTime(nullable: false),
                        CheckOutDate = c.DateTime(nullable: false),
                        IsCheckout = c.Boolean(nullable: false),
                        DeleteStatus = c.Boolean(nullable: false),
                        customer_ID = c.Int(),
                        user_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.customer_ID)
                .ForeignKey("dbo.Users", t => t.user_ID)
                .Index(t => t.customer_ID)
                .Index(t => t.user_ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Double(nullable: false),
                        Stock = c.Int(nullable: false),
                        DeleteStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                        Picture = c.String(),
                        DeleteStatus = c.Boolean(nullable: false),
                        Status = c.Boolean(nullable: false),
                        RegDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Reminders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        ReminderInfo = c.String(),
                        RegDate = c.DateTime(nullable: false),
                        ReminderDate = c.DateTime(nullable: false),
                        IsDone = c.Boolean(),
                        DeleteStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ProductInVoices",
                c => new
                    {
                        Product_ID = c.Int(nullable: false),
                        InVoice_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Product_ID, t.InVoice_ID })
                .ForeignKey("dbo.Products", t => t.Product_ID, cascadeDelete: true)
                .ForeignKey("dbo.InVoices", t => t.InVoice_ID, cascadeDelete: true)
                .Index(t => t.Product_ID)
                .Index(t => t.InVoice_ID);
            
            CreateTable(
                "dbo.ReminderUsers",
                c => new
                    {
                        Reminder_ID = c.Int(nullable: false),
                        User_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Reminder_ID, t.User_ID })
                .ForeignKey("dbo.Reminders", t => t.Reminder_ID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_ID, cascadeDelete: true)
                .Index(t => t.Reminder_ID)
                .Index(t => t.User_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReminderUsers", "User_ID", "dbo.Users");
            DropForeignKey("dbo.ReminderUsers", "Reminder_ID", "dbo.Reminders");
            DropForeignKey("dbo.InVoices", "user_ID", "dbo.Users");
            DropForeignKey("dbo.Activities", "user_ID", "dbo.Users");
            DropForeignKey("dbo.ProductInVoices", "InVoice_ID", "dbo.InVoices");
            DropForeignKey("dbo.ProductInVoices", "Product_ID", "dbo.Products");
            DropForeignKey("dbo.InVoices", "customer_ID", "dbo.Customers");
            DropForeignKey("dbo.Activities", "customer_ID", "dbo.Customers");
            DropForeignKey("dbo.Activities", "ActivityCategory_ID", "dbo.ActivityCategories");
            DropIndex("dbo.ReminderUsers", new[] { "User_ID" });
            DropIndex("dbo.ReminderUsers", new[] { "Reminder_ID" });
            DropIndex("dbo.ProductInVoices", new[] { "InVoice_ID" });
            DropIndex("dbo.ProductInVoices", new[] { "Product_ID" });
            DropIndex("dbo.InVoices", new[] { "user_ID" });
            DropIndex("dbo.InVoices", new[] { "customer_ID" });
            DropIndex("dbo.Activities", new[] { "user_ID" });
            DropIndex("dbo.Activities", new[] { "customer_ID" });
            DropIndex("dbo.Activities", new[] { "ActivityCategory_ID" });
            DropTable("dbo.ReminderUsers");
            DropTable("dbo.ProductInVoices");
            DropTable("dbo.Reminders");
            DropTable("dbo.Users");
            DropTable("dbo.Products");
            DropTable("dbo.InVoices");
            DropTable("dbo.Customers");
            DropTable("dbo.ActivityCategories");
            DropTable("dbo.Activities");
        }
    }
}
