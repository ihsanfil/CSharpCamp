using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Veritabanını başlatma
            using (var context = new ApplicationDbContext())
            {
                // Veritabanı varsa işlem yapma
                context.Database.Initialize(force: false);  // force: false veritabanı varsa yeniden oluşturmaz
            }

            // Formu başlatma
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmBilldig());
        }
        //static void Main()
        //{
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    Application.Run(new FrmLogin());
        //}
    }
}
