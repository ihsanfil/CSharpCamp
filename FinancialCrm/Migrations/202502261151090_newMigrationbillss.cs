namespace FinancialCrm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newMigrationbillss : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BankProcesses",
                c => new
                    {
                        BankProcessId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        ProcessDate = c.DateTime(nullable: false),
                        ProcessType = c.String(),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BankId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BankProcessId)
                .ForeignKey("dbo.Banks", t => t.BankId, cascadeDelete: true)
                .Index(t => t.BankId);
            
            CreateTable(
                "dbo.Banks",
                c => new
                    {
                        BankId = c.Int(nullable: false, identity: true),
                        BankAccountNumber = c.String(),
                        BankTitle = c.String(),
                        BankBalance = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.BankId);
            
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        BillId = c.Int(nullable: false, identity: true),
                        BillTitle = c.String(),
                        BillAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BillPeriod = c.String(),
                    })
                .PrimaryKey(t => t.BillId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Spendings",
                c => new
                    {
                        SpendingId = c.Int(nullable: false, identity: true),
                        SpendingTitle = c.String(),
                        SpendingAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SpendingDate = c.DateTime(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SpendingId)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        PasswordHash = c.String(),
                        Email = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Spendings", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.BankProcesses", "BankId", "dbo.Banks");
            DropIndex("dbo.Spendings", new[] { "CategoryId" });
            DropIndex("dbo.BankProcesses", new[] { "BankId" });
            DropTable("dbo.Users");
            DropTable("dbo.Spendings");
            DropTable("dbo.Categories");
            DropTable("dbo.Bills");
            DropTable("dbo.Banks");
            DropTable("dbo.BankProcesses");
        }
    }
}
