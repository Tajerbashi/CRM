namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ver1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserAccessRoles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Section = c.String(),
                        CanCreate = c.Boolean(nullable: false),
                        CanEnter = c.Boolean(nullable: false),
                        CanDelete = c.Boolean(nullable: false),
                        CanUpdate = c.Boolean(nullable: false),
                        UserGroup_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UserGroups", t => t.UserGroup_ID)
                .Index(t => t.UserGroup_ID);
            
            CreateTable(
                "dbo.UserGroups",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
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
                        UserGroup_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UserGroups", t => t.UserGroup_ID)
                .Index(t => t.UserGroup_ID);
            
            CreateTable(
                "dbo.Activities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Info = c.String(),
                        RegDate = c.DateTime(nullable: false),
                        ReminderDate = c.DateTime(nullable: false),
                        DeleteStatus = c.Boolean(nullable: false),
                        ReminderClock = c.Boolean(nullable: false),
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
                        DeleteStatus = c.Boolean(nullable: false),
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
                        InvoiceNumber = c.Int(nullable: false),
                        RegDate = c.DateTime(nullable: false),
                        CheckOutDate = c.DateTime(),
                        IsCheckout = c.Boolean(nullable: false),
                        inVoicePrice = c.Double(nullable: false),
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
                        RegDate = c.DateTime(nullable: false),
                        Stock = c.Int(nullable: false),
                        DeleteStatus = c.Boolean(nullable: false),
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
                        Users_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.Users_ID)
                .Index(t => t.Users_ID);
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "UserGroup_ID", "dbo.UserGroups");
            DropForeignKey("dbo.Reminders", "Users_ID", "dbo.Users");
            DropForeignKey("dbo.Activities", "user_ID", "dbo.Users");
            DropForeignKey("dbo.InVoices", "user_ID", "dbo.Users");
            DropForeignKey("dbo.ProductInVoices", "InVoice_ID", "dbo.InVoices");
            DropForeignKey("dbo.ProductInVoices", "Product_ID", "dbo.Products");
            DropForeignKey("dbo.InVoices", "customer_ID", "dbo.Customers");
            DropForeignKey("dbo.Activities", "customer_ID", "dbo.Customers");
            DropForeignKey("dbo.Activities", "ActivityCategory_ID", "dbo.ActivityCategories");
            DropForeignKey("dbo.UserAccessRoles", "UserGroup_ID", "dbo.UserGroups");
            DropIndex("dbo.ProductInVoices", new[] { "InVoice_ID" });
            DropIndex("dbo.ProductInVoices", new[] { "Product_ID" });
            DropIndex("dbo.Reminders", new[] { "Users_ID" });
            DropIndex("dbo.InVoices", new[] { "user_ID" });
            DropIndex("dbo.InVoices", new[] { "customer_ID" });
            DropIndex("dbo.Activities", new[] { "user_ID" });
            DropIndex("dbo.Activities", new[] { "customer_ID" });
            DropIndex("dbo.Activities", new[] { "ActivityCategory_ID" });
            DropIndex("dbo.Users", new[] { "UserGroup_ID" });
            DropIndex("dbo.UserAccessRoles", new[] { "UserGroup_ID" });
            DropTable("dbo.ProductInVoices");
            DropTable("dbo.Reminders");
            DropTable("dbo.Products");
            DropTable("dbo.InVoices");
            DropTable("dbo.Customers");
            DropTable("dbo.ActivityCategories");
            DropTable("dbo.Activities");
            DropTable("dbo.Users");
            DropTable("dbo.UserGroups");
            DropTable("dbo.UserAccessRoles");
        }
    }
}
