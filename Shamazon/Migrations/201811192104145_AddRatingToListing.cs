namespace Shamazon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRatingToListing : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Listings", "Rating", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Listings", "Rating");
        }
    }
}
