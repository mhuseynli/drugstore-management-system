namespace DrugStoreManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reset : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        categoryId = c.Int(nullable: false, identity: true),
                        categoryName = c.String(),
                    })
                .PrimaryKey(t => t.categoryId);
            
            CreateTable(
                "dbo.Medicines",
                c => new
                    {
                        medicineId = c.Int(nullable: false, identity: true),
                        medicineName = c.String(),
                        medicineBarcode = c.Int(nullable: false),
                        medicinePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        medicineSellingPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        categoryId = c.Int(nullable: false),
                        manufacturerId = c.Int(nullable: false),
                        formatId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.medicineId)
                .ForeignKey("dbo.Categories", t => t.categoryId, cascadeDelete: true)
                .ForeignKey("dbo.Manufacturers", t => t.manufacturerId, cascadeDelete: true)
                .ForeignKey("dbo.MedicineFormats", t => t.formatId, cascadeDelete: true)
                .Index(t => t.categoryId)
                .Index(t => t.manufacturerId)
                .Index(t => t.formatId);
            
            CreateTable(
                "dbo.Inventories",
                c => new
                    {
                        inventoryId = c.Int(nullable: false, identity: true),
                        count = c.Int(nullable: false),
                        medicineId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.inventoryId)
                .ForeignKey("dbo.Medicines", t => t.medicineId, cascadeDelete: true)
                .Index(t => t.medicineId);
            
            CreateTable(
                "dbo.Manufacturers",
                c => new
                    {
                        manufacturerId = c.Int(nullable: false, identity: true),
                        manufacturerName = c.String(),
                    })
                .PrimaryKey(t => t.manufacturerId);
            
            CreateTable(
                "dbo.MedicineFormats",
                c => new
                    {
                        formatId = c.Int(nullable: false, identity: true),
                        formatName = c.String(),
                    })
                .PrimaryKey(t => t.formatId);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        saleId = c.Int(nullable: false, identity: true),
                        saleDate = c.DateTime(nullable: false),
                        profit = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.saleId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        userId = c.Int(nullable: false, identity: true),
                        userName = c.String(),
                        userPassword = c.String(),
                    })
                .PrimaryKey(t => t.userId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Medicines", "formatId", "dbo.MedicineFormats");
            DropForeignKey("dbo.Medicines", "manufacturerId", "dbo.Manufacturers");
            DropForeignKey("dbo.Inventories", "medicineId", "dbo.Medicines");
            DropForeignKey("dbo.Medicines", "categoryId", "dbo.Categories");
            DropIndex("dbo.Inventories", new[] { "medicineId" });
            DropIndex("dbo.Medicines", new[] { "formatId" });
            DropIndex("dbo.Medicines", new[] { "manufacturerId" });
            DropIndex("dbo.Medicines", new[] { "categoryId" });
            DropTable("dbo.Users");
            DropTable("dbo.Sales");
            DropTable("dbo.MedicineFormats");
            DropTable("dbo.Manufacturers");
            DropTable("dbo.Inventories");
            DropTable("dbo.Medicines");
            DropTable("dbo.Categories");
        }
    }
}
