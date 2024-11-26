using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCamp301.EFProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        CSharpCampTravelEfDbEntities1 db = new CSharpCampTravelEfDbEntities1();
        private void btnList_Click(object sender, EventArgs e)
        {         
            var values = db.Guid.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Guid guid = new Guid();
            guid.Name = txtName.Text;
            guid.Surname = txtSurname.Text;
            db.Guid.Add(guid);
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla eklendi");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtId.Text);
            var guid = db.Guid.FirstOrDefault(x => x.GuidId == id);
            if (guid != null)
            {
                db.Guid.Remove(guid);
                db.SaveChanges();
                MessageBox.Show("Rehber Başarıyla Silindi");

            }
            else
            {
                MessageBox.Show("Bu id ile Rehber Bulunamadı");
            }
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtId.Text);
            var guid = db.Guid.FirstOrDefault(x => x.GuidId == id);
            if (guid != null)
            {
                guid.Name = txtName.Text;
                guid.Surname = txtSurname.Text;
                db.Guid.AddOrUpdate(guid);
                db.SaveChanges();
                MessageBox.Show("Rehber Başarıyla Güncellendi","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("Bu id ile Rehber Bulunamadı");
            }
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtId.Text);
            var values = db.Guid.Where(x => x.GuidId == id).ToList();
            dataGridView1.DataSource = values;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
