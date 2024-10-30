using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Crud--> Create-Read-Update-Delete
            Console.WriteLine("***** MENÜ SİPARİŞ İŞLEM PANELİ *****");
            //Console.WriteLine();

            //Console.WriteLine("--------------------------------------------------------------------");

            #region ADD CATEGORY | KATEGORİ EKLEME

            //Console.Write("Eklemek istediğiniz kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-9NMT7SV\\SQLEXPRESS;Initial Catalog=EgitimKampiDB;Integrated Security=True;");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery(); // Koşulsuz bir şekilde sorguyu çalıştır.
            //connection.Close();

            //Console.Write("Kategori başarı ile eklendi.");

            #endregion

            //*******************************************************************

            #region ADD PRODUCT | ÜRÜN EKLEME

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();

            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-9NMT7SV\\SQLEXPRESS;Initial Catalog=EgitimKampiDB;Integrated Security=True;");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Insert into TblProduct (ProductName, ProductPrice, ProductStatus) values (@productName, @productPrice, @productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Ürün başarılı bir şekilde eklendi.");

            #endregion

            //*******************************************************************

            #region PRODUCT LISTİNG | ÜRÜN LİSTELEME

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-9NMT7SV\\SQLEXPRESS;Initial Catalog=EgitimKampiDB;Integrated Security=True;");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            #endregion

            //*******************************************************************

            #region DELETE PRODUCT | ÜRÜN SİLME

            //Console.Write("Silinecek Ürün ID: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-9NMT7SV\\SQLEXPRESS;Initial Catalog=EgitimKampiDB;Integrated Security=True;");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete from TblProduct Where ProductId = @productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Ürün başarılı bir şekilde silindi.");

            #endregion

            //*******************************************************************

            #region UPDATE PRODUCT | ÜRÜN GÜNCELLEME

            Console.Write("Güncellenecek Ürün ID: ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Güncellenecek Ürün Adı: ");
            string productName = Console.ReadLine();

            Console.Write("Güncellenecek Ürün Fİyatı: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-9NMT7SV\\SQLEXPRESS;Initial Catalog=EgitimKampiDB;Integrated Security=True;");
            connection.Open();

            SqlCommand command = new SqlCommand("Update TblProduct Set ProductName = @productName, ProductPrice = @productPrice Where ProductId = @productId", connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();
            connection.Close();

            Console.WriteLine("Ürün başarılı bir şekilde güncellendi.");

            #endregion


            Console.Read();
        }
    }
}
