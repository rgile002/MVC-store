namespace MvcStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial_migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(nullable: false, maxLength: 100),
                        CustomerEmail = c.String(nullable: false, maxLength: 60),
                        CustomerPhone = c.String(nullable: false, maxLength: 100),
                        CustomerCountry = c.String(nullable: false, maxLength: 100),
                        CustomerImage = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        Customer_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.Customer_ID)
                .Index(t => t.Customer_ID);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        Order_ID = c.Int(),
                        Product_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Orders", t => t.Order_ID)
                .ForeignKey("dbo.Products", t => t.Product_ID)
                .Index(t => t.Order_ID)
                .Index(t => t.Product_ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false, maxLength: 100),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UnitsInStock = c.Int(nullable: false),
                        ProductImage = c.String(nullable: false, maxLength: 100),
                        ProductType = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDetails", "Product_ID", "dbo.Products");
            DropForeignKey("dbo.OrderDetails", "Order_ID", "dbo.Orders");
            DropForeignKey("dbo.Orders", "Customer_ID", "dbo.Customers");
            DropIndex("dbo.OrderDetails", new[] { "Product_ID" });
            DropIndex("dbo.OrderDetails", new[] { "Order_ID" });
            DropIndex("dbo.Orders", new[] { "Customer_ID" });
            DropTable("dbo.Products");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Orders");
            DropTable("dbo.Customers");
        }
    }
}
