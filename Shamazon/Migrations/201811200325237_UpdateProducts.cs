namespace Shamazon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProducts : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Listings", newName: "Products");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Products", newName: "Listings");
        }
    }
}
