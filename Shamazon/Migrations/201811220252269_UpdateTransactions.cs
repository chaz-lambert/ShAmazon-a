namespace Shamazon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTransactions : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transactions", "OwnerId", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Transactions", "SellerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "SellerId", c => c.Int(nullable: false));
            DropColumn("dbo.Transactions", "OwnerId");
        }
    }
}
