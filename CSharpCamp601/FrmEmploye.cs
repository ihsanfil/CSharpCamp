using MongoDB.Driver.Core.Configuration;
using Npgsql;
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
    public partial class FrmEmploye : Form
    {
        public FrmEmploye()
        {
            InitializeComponent();
        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {

        }
        string connectionString = "Server= localhost;port=5432;Database= CustomerDb;user Id=postgres; Password=12345";
        void EmployeeList()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From Employees";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridEmp.DataSource = dataTable;
            connection.Close();
        }

        void DepartmentList()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From Departments";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            cmbEmpDepartment.DisplayMember = "DepartmentName";
            cmbEmpDepartment.ValueMember = "DepartmentId";
            cmbEmpDepartment.DataSource = dataTable;
            connection.Close();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            EmployeeList();
        }

        private void FrmEmploye_Load(object sender, EventArgs e)
        {
            EmployeeList();
            DepartmentList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string employeeName = txtEmpName.Text;
            string employeeSurname = txtEmpSurname.Text;
            int employeeSalary = int.Parse(txtEmpMaas.Text);
            int departmentId = int.Parse(cmbEmpDepartment.SelectedValue.ToString());

            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "insert into Employees (EmployeeName, EmployeeSurname, EmployeeSalary, DepartmentId) values (@employeeName, @employeeSurname, @employeeSalary, @departmentId)";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@employeeName", employeeName);
            command.Parameters.AddWithValue("@employeeSurname", employeeSurname);
            command.Parameters.AddWithValue("@employeeSalary", employeeSalary);
            command.Parameters.AddWithValue("@departmentId", departmentId);
            command.ExecuteNonQuery();
            MessageBox.Show("Ekleme işlemi başarılı");
            connection.Close();
            EmployeeList();
        }
    }
}
