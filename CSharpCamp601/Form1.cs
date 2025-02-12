using CSharpCamp601.Entities;
using CSharpCamp601.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCamp601
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CustomerOperation customerOperation = new CustomerOperation();
        private void btnCustomerCreate_Click(object sender, EventArgs e)
        {
            var customer = new Customer()
            {
                CustomerName = txtCustomerName.Text,
                CustomerSurName = txtCustomerBalance.Text,
                CustomerCity = txtCustomerCity.Text,
                CustomerBalance = decimal.Parse(txtCustomerBalance.Text),
                CustomerShoppingCount = int.Parse(txtCustomerShoppingCount.Text)
            };
            customerOperation.AddCustomer(customer);
            MessageBox.Show("Müşteri Ekleme İşlemi Başarılı","Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Customer> customers = customerOperation.GetAllCustomer();
            dataGrid1.DataSource = customers;
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            string customerId = txtCustomerId.Text;
            customerOperation.DeleteCustomer(customerId);
            MessageBox.Show("Müşteri başarıyla silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            
            var updateCustomer = new Customer()
            {
                CustomerId = txtCustomerId.Text,
                CustomerName = txtCustomerName.Text,
                CustomerSurName = txtCustomerSurname.Text,
                CustomerCity = txtCustomerCity.Text,
                CustomerBalance = decimal.Parse(txtCustomerBalance.Text),        
                CustomerShoppingCount = int.Parse(txtCustomerBalance.Text)
            };
            customerOperation.UpdateCustomer(updateCustomer);
            MessageBox.Show("Güncelleme başarıyla tamamlandı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGetId_Click(object sender, EventArgs e)
        {
            var customer = customerOperation.GetCustomerById(txtCustomerId.Text);
            dataGrid1.DataSource = new List<Customer> { customer };

        }
    }
}
