namespace Shamazon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShoppingCart_take1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ShoppingCartItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(maxLength: 128),
                        Quantity = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShoppingCartItems", "ProductId", "dbo.Products");
            DropIndex("dbo.ShoppingCartItems", new[] { "ProductId" });
            DropTable("dbo.ShoppingCartItems");
        }
    }
}
