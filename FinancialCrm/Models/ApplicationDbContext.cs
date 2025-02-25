using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace FinancialCrm.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<BankProcess> BankProcesses { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Spending> Spendings { get; set; }

        // Bağlantı dizesini manuel olarak veriyoruz
        public ApplicationDbContext(): base(@"Server=DESKTOP-9NMT7SV\SQLEXPRESS;Database=FinancialCrmDb2;Integrated Security=True;")
        {
            // Bu bağlantı dizesi manuel olarak belirlenmiştir.
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
