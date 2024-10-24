using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ado.Net

            // İlk Açılan Ekran
            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.WriteLine();
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("--------------------------------------------------------------------");

            // SQL Bağlantısı
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-9NMT7SV\\SQLEXPRESS;Initial Catalog=EgitimKampiDB;Integrated Security=True;");
            // SQL bağlantısı açılır.
            connection.Open();
            // SQL'de kullanılacak sorgu buraya yazılır.
            SqlCommand command = new SqlCommand("Select * From TblCategory", connection);
            // C# tarafında oluşturulan sorgu ile SQL arasında köprü görevi görür.
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            // Veri tablolarını hafızada tutmak için ve üzerinde işlem yapmak için kullanılır.
            DataTable context = new DataTable();
            adapter.Fill(context);
            // SQL bağlantısı kapatılır.
            connection.Close();

            foreach (DataRow row in context.Rows)
            {
                //Console.WriteLine(row);
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }

            #endregion

            Console.Read();
        }
    }
}
