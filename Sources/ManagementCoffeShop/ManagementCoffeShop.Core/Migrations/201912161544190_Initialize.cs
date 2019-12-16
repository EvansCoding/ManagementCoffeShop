namespace ManagementCoffeShop.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialize : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Area",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        nameArea = c.String(nullable: false, maxLength: 100),
                        Note = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tables",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        nameTable = c.String(nullable: false, maxLength: 100),
                        status = c.Boolean(nullable: false),
                        Note = c.String(maxLength: 200),
                        Area_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Area", t => t.Area_Id)
                .Index(t => t.Area_Id);
            
            CreateTable(
                "dbo.BillSell",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        createDate = c.DateTime(nullable: false),
                        totalMoney = c.Decimal(nullable: false, precision: 18, scale: 2),
                        status = c.Boolean(nullable: false),
                        Employe_Id = c.Guid(nullable: false),
                        Table_Id = c.Guid(nullable: false),
                        Customer_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employe", t => t.Employe_Id)
                .ForeignKey("dbo.Tables", t => t.Table_Id)
                .ForeignKey("dbo.Customer", t => t.Customer_Id)
                .Index(t => t.Employe_Id)
                .Index(t => t.Table_Id)
                .Index(t => t.Customer_Id);
            
            CreateTable(
                "dbo.DetailBillSell",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Quantum = c.Int(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Product_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Product", t => t.Product_Id)
                .Index(t => t.Product_Id);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        nameProduct = c.String(nullable: false, maxLength: 100),
                        pathImage = c.String(nullable: false, maxLength: 100),
                        priceProduct = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProductType_Id = c.Guid(nullable: false),
                        Unit_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductType", t => t.ProductType_Id)
                .ForeignKey("dbo.Unit", t => t.Unit_Id)
                .Index(t => t.ProductType_Id)
                .Index(t => t.Unit_Id);
            
            CreateTable(
                "dbo.ProductType",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        nameProductType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Unit",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        nameUnit = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RawMaterial",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        nameRawMaterial = c.String(nullable: false, maxLength: 100),
                        priceRawMaterial = c.Decimal(nullable: false, precision: 18, scale: 2),
                        InventoryNumber = c.Int(nullable: false),
                        Unit_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Unit", t => t.Unit_Id)
                .Index(t => t.Unit_Id);
            
            CreateTable(
                "dbo.Supplier",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        nameSupplier = c.String(nullable: false, maxLength: 100),
                        address = c.String(nullable: false, maxLength: 100),
                        phoneNumber = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employe",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        userName = c.String(nullable: false, maxLength: 100),
                        password = c.String(nullable: false, maxLength: 100),
                        fullName = c.String(nullable: false, maxLength: 100),
                        sex = c.Boolean(nullable: false),
                        birthDay = c.DateTime(nullable: false),
                        address = c.String(nullable: false, maxLength: 500),
                        phoneNumber = c.String(nullable: false, maxLength: 11),
                        email = c.String(),
                        dayAtWork = c.DateTime(nullable: false),
                        statusOfWork = c.Boolean(nullable: false),
                        createDate = c.DateTime(nullable: false),
                        updateDate = c.DateTime(nullable: false),
                        Office_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Office", t => t.Office_Id)
                .Index(t => t.Office_Id);
            
            CreateTable(
                "dbo.Office",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        nameOffice = c.String(),
                        createdDay = c.DateTime(nullable: false),
                        updatedDay = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        nameCustomer = c.String(nullable: false, maxLength: 100),
                        phoneNumber = c.String(maxLength: 11),
                        status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Bill_DetailBill",
                c => new
                    {
                        DetailBillSell_Id = c.Guid(nullable: false),
                        BillSell_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.DetailBillSell_Id, t.BillSell_Id })
                .ForeignKey("dbo.DetailBillSell", t => t.DetailBillSell_Id, cascadeDelete: true)
                .ForeignKey("dbo.BillSell", t => t.BillSell_Id, cascadeDelete: true)
                .Index(t => t.DetailBillSell_Id)
                .Index(t => t.BillSell_Id);
            
            CreateTable(
                "dbo.DetailRawMaterial",
                c => new
                    {
                        RawMaterial_Id = c.Guid(nullable: false),
                        Supplier_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.RawMaterial_Id, t.Supplier_Id })
                .ForeignKey("dbo.RawMaterial", t => t.RawMaterial_Id, cascadeDelete: true)
                .ForeignKey("dbo.Supplier", t => t.Supplier_Id, cascadeDelete: true)
                .Index(t => t.RawMaterial_Id)
                .Index(t => t.Supplier_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BillSell", "Customer_Id", "dbo.Customer");
            DropForeignKey("dbo.BillSell", "Table_Id", "dbo.Tables");
            DropForeignKey("dbo.BillSell", "Employe_Id", "dbo.Employe");
            DropForeignKey("dbo.Employe", "Office_Id", "dbo.Office");
            DropForeignKey("dbo.DetailBillSell", "Product_Id", "dbo.Product");
            DropForeignKey("dbo.Product", "Unit_Id", "dbo.Unit");
            DropForeignKey("dbo.RawMaterial", "Unit_Id", "dbo.Unit");
            DropForeignKey("dbo.DetailRawMaterial", "Supplier_Id", "dbo.Supplier");
            DropForeignKey("dbo.DetailRawMaterial", "RawMaterial_Id", "dbo.RawMaterial");
            DropForeignKey("dbo.Product", "ProductType_Id", "dbo.ProductType");
            DropForeignKey("dbo.Bill_DetailBill", "BillSell_Id", "dbo.BillSell");
            DropForeignKey("dbo.Bill_DetailBill", "DetailBillSell_Id", "dbo.DetailBillSell");
            DropForeignKey("dbo.Tables", "Area_Id", "dbo.Area");
            DropIndex("dbo.DetailRawMaterial", new[] { "Supplier_Id" });
            DropIndex("dbo.DetailRawMaterial", new[] { "RawMaterial_Id" });
            DropIndex("dbo.Bill_DetailBill", new[] { "BillSell_Id" });
            DropIndex("dbo.Bill_DetailBill", new[] { "DetailBillSell_Id" });
            DropIndex("dbo.Employe", new[] { "Office_Id" });
            DropIndex("dbo.RawMaterial", new[] { "Unit_Id" });
            DropIndex("dbo.Product", new[] { "Unit_Id" });
            DropIndex("dbo.Product", new[] { "ProductType_Id" });
            DropIndex("dbo.DetailBillSell", new[] { "Product_Id" });
            DropIndex("dbo.BillSell", new[] { "Customer_Id" });
            DropIndex("dbo.BillSell", new[] { "Table_Id" });
            DropIndex("dbo.BillSell", new[] { "Employe_Id" });
            DropIndex("dbo.Tables", new[] { "Area_Id" });
            DropTable("dbo.DetailRawMaterial");
            DropTable("dbo.Bill_DetailBill");
            DropTable("dbo.Customer");
            DropTable("dbo.Office");
            DropTable("dbo.Employe");
            DropTable("dbo.Supplier");
            DropTable("dbo.RawMaterial");
            DropTable("dbo.Unit");
            DropTable("dbo.ProductType");
            DropTable("dbo.Product");
            DropTable("dbo.DetailBillSell");
            DropTable("dbo.BillSell");
            DropTable("dbo.Tables");
            DropTable("dbo.Area");
        }
    }
}
