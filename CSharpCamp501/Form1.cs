using CSharpCamp501.Dtos;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCamp501
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Server=DESKTOP-9NMT7SV\\SQLEXPRESS;initial Catalog=EgitimKampi501DB; integrated security=true;");
        private async void Form1_Load(object sender, EventArgs e)
        {
            string query = "Select Count(*) From TblProduct";
            var ProductTotalCount = await connection.QueryFirstOrDefaultAsync<int>(query);
            lblTotalProductCount.Text = ProductTotalCount.ToString();

            string query2 = "Select ProductName From TblProduct Where ProductPrice = (Select Max(ProductPrice) From TblProduct)";
            var MaxPriceProduct = await connection.QueryFirstOrDefaultAsync<string>(query2);
            lblMaxPrice.Text = MaxPriceProduct;


            string query3 = "Select Count (Distinct(ProductCategory)) From TblProduct";
            var CategoryCount = await connection.QueryFirstOrDefaultAsync<int>(query3);
            lblCategoryCount.Text = CategoryCount.ToString();
        }

        private async void btnList_Click(object sender, EventArgs e)
        {
            string query = "Select * From TblProduct";
            var values = await connection.QueryAsync<ResultProductDtos>(query);
            dataGridView1.DataSource = values;
        }

        private async void btnRemove_Click(object sender, EventArgs e)
        {
            string query = "Delete From TblProduct Where ProductId = @txtId";
            var parameters = new DynamicParameters();
            parameters.Add("@txtId", txtId.Text);
            await connection.ExecuteAsync(query, parameters);
            MessageBox.Show("kitap silme işlemi başarılı");
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "insert into TblProduct (ProductName,ProductStock,ProductPrice,ProductCategory) values (@txtName,@txtStock,@txtPrice,@txtCategory)";
            var parameters = new DynamicParameters();
            parameters.Add("@txtName", txtName.Text);
            parameters.Add("@txtStock",txtStock.Text);
            parameters.Add("@txtPrice", txtPrice.Text);
            parameters.Add("@txtCategory", txtCategory.Text);
            await connection.ExecuteAsync(query, parameters);
            MessageBox.Show("Yeni kitap ekleme işlemi başarılı");

           
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "Update TblProduct Set ProductName=@txtName, ProductPrice=@txtPrice,ProductStock = @txtStock, ProductCategory = @txtCategory where ProductId = @txtId";
            var parameters = new DynamicParameters();
            parameters.Add("@txtName", txtName.Text);
            parameters.Add("@txtStock", txtStock.Text);
            parameters.Add("@txtPrice", txtPrice.Text);
            parameters.Add("@txtCategory", txtCategory.Text);
            parameters.Add("@txtId", txtId.Text);
            await connection.ExecuteAsync(query, parameters);
            MessageBox.Show("Kitap güncelleme işlemi başarılı","Güncelleme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
