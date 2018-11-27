namespace Shamazon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDescriptionToListing : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Listings", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Listings", "Description");
        }
    }
}
