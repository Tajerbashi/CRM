namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ver5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.InVoices", "InvoiceNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.InVoices", "InvoiceNumber", c => c.String());
        }
    }
}
