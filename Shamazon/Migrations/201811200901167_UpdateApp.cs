namespace Shamazon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateApp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "SellerName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "SellerName");
        }
    }
}
