namespace Shamazon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsSeller : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "IsSeller", c => c.Boolean(nullable: false));
            DropColumn("dbo.Users", "Buyer");
            DropColumn("dbo.Users", "Seller");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Seller", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "Buyer", c => c.Boolean(nullable: false));
            DropColumn("dbo.Users", "IsSeller");
        }
    }
}
