namespace FinancialCrm.Migrations
{
    using FinancialCrm.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FinancialCrm.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FinancialCrm.Models.ApplicationDbContext context)
        {
            // Banka verilerini ekleyelim
            context.Banks.AddOrUpdate(
                b => b.BankAccountNumber,
                new Bank { BankAccountNumber = "1234567890", BankTitle = "Bank of America", BankBalance = 10000 },
                new Bank { BankAccountNumber = "9876543210", BankTitle = "Wells Fargo", BankBalance = 5000 },
                new Bank { BankAccountNumber = "1112223333", BankTitle = "Chase Bank", BankBalance = 15000 },
                new Bank { BankAccountNumber = "4445556666", BankTitle = "Citibank", BankBalance = 7000 },
                new Bank { BankAccountNumber = "7778889990", BankTitle = "Bank of New York", BankBalance = 12000 },
                new Bank { BankAccountNumber = "0001112222", BankTitle = "HSBC", BankBalance = 9500 }
            );

            // Banka işlemleri verilerini ekleyelim
            context.BankProcesses.AddOrUpdate(
                bp => bp.Description,
                new BankProcess { Description = "Deposit", ProcessDate = DateTime.Now, ProcessType = "Deposit", Amount = 2000, BankId = 1 },
                new BankProcess { Description = "Withdrawal", ProcessDate = DateTime.Now, ProcessType = "Withdrawal", Amount = 500, BankId = 2 },
                new BankProcess { Description = "Transfer", ProcessDate = DateTime.Now, ProcessType = "Transfer", Amount = 3000, BankId = 3 },
                new BankProcess { Description = "Deposit", ProcessDate = DateTime.Now, ProcessType = "Deposit", Amount = 1000, BankId = 4 },
                new BankProcess { Description = "Withdrawal", ProcessDate = DateTime.Now, ProcessType = "Withdrawal", Amount = 1500, BankId = 5 },
                new BankProcess { Description = "Transfer", ProcessDate = DateTime.Now, ProcessType = "Transfer", Amount = 2500, BankId = 6 }
            );


            // Fatura verilerini ekleyelim
            context.Bills.AddOrUpdate(
                b => b.BillTitle,
                new Bill { BillTitle = "Electricity Bill", BillAmount = 150.75m, BillPeriod = "January 2025" },
                new Bill { BillTitle = "Water Bill", BillAmount = 50.25m, BillPeriod = "January 2025" }
            );

            // Kategori verilerini ekleyelim
            context.Categories.AddOrUpdate(
                c => c.CategoryName,
                new Category { CategoryName = "Groceries" },
                new Category { CategoryName = "Utilities" },
                new Category { CategoryName = "Entertainment" }
            );

            // Harcama verilerini ekleyelim
            context.Spendings.AddOrUpdate(
                s => s.SpendingTitle,
                new Spending { SpendingTitle = "Grocery Shopping", SpendingAmount = 75.50m, SpendingDate = DateTime.Now, CategoryId = 1 },
                new Spending { SpendingTitle = "Electricity Bill Payment", SpendingAmount = 150.75m, SpendingDate = DateTime.Now, CategoryId = 2 },
                new Spending { SpendingTitle = "Movie Tickets", SpendingAmount = 30.00m, SpendingDate = DateTime.Now, CategoryId = 3 }
            );

            // Kullanıcı verilerini ekleyelim
            //context.Users.AddOrUpdate(
            //    u => u.UserName,
            //    new User { UserName = "john.doe", Password = "password123" },
            //    new User { UserName = "jane.smith", Password = "password456" }
            //);
        }
    }
}
