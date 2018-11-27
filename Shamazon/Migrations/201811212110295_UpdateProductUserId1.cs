namespace Shamazon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProductUserId1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "OwnerId", c => c.String(maxLength: 128));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "OwnerId", c => c.Int(nullable: false));
        }
    }
}
