namespace ECommerce_Web01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _initalCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NameCategory = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NameProduct = c.String(nullable: false),
                        Quantity = c.Int(nullable: false),
                        UniPrice = c.Double(nullable: false),
                        Image = c.String(),
                        Category_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.Category_ID)
                .Index(t => t.Category_ID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CodeCus = c.Int(nullable: false, identity: true),
                        ID = c.Int(nullable: false),
                        NameCus = c.String(nullable: false),
                        AddressCus = c.String(nullable: false),
                        PhoneCus = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.CodeCus);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        AddressDelivery = c.String(nullable: false),
                        Customer_CodeCus = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.Customer_CodeCus)
                .Index(t => t.Customer_CodeCus);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        QuantitySale = c.Int(nullable: false),
                        UnitPriceSale = c.Double(nullable: false),
                        Order_ID = c.Int(),
                        Product_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Orders", t => t.Order_ID)
                .ForeignKey("dbo.Products", t => t.Product_ID)
                .Index(t => t.Order_ID)
                .Index(t => t.Product_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDetails", "Product_ID", "dbo.Products");
            DropForeignKey("dbo.OrderDetails", "Order_ID", "dbo.Orders");
            DropForeignKey("dbo.Orders", "Customer_CodeCus", "dbo.Customers");
            DropForeignKey("dbo.Products", "Category_ID", "dbo.Categories");
            DropIndex("dbo.OrderDetails", new[] { "Product_ID" });
            DropIndex("dbo.OrderDetails", new[] { "Order_ID" });
            DropIndex("dbo.Orders", new[] { "Customer_CodeCus" });
            DropIndex("dbo.Products", new[] { "Category_ID" });
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Orders");
            DropTable("dbo.Customers");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
