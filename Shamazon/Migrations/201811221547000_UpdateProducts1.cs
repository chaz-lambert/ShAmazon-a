namespace Shamazon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProducts1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "SellerId", c => c.String(maxLength: 128));
            AddColumn("dbo.Products", "SellerName", c => c.String());
            DropColumn("dbo.Products", "OwnerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "OwnerId", c => c.String(maxLength: 128));
            DropColumn("dbo.Products", "SellerName");
            DropColumn("dbo.Products", "SellerId");
        }
    }
}
