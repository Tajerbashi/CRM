namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ver3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.InVoices", "CheckOutDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.InVoices", "CheckOutDate", c => c.DateTime(nullable: false));
        }
    }
}
