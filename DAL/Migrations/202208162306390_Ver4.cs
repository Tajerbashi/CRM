namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ver4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.InVoices", "inVoicePrice", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.InVoices", "inVoicePrice");
        }
    }
}
