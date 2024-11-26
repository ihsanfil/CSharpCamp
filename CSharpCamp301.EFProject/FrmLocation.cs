using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCamp301.EFProject
{
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }
        CSharpCampTravelEfDbEntities1 db = new CSharpCampTravelEfDbEntities1();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Location.Select(location => new
            {
                DayNight = location.DayNight,
                Price = location.Price,
                Capacity = location.Capacity,
                City = location.City,
                Country = location.Country,
                GuidId = location.GuidId,
                Guid = location.Guid.Name + " " + location.Guid.Surname 
            }).ToList();

            dataGridView1.DataSource = values; 

        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.Guid.Select(x => new
            {
                FullName = (x.Name ?? "") + " " + (x.Surname ?? ""),
                x.GuidId
            }).ToList();

            cmbGuid.DisplayMember = "FullName";
            cmbGuid.ValueMember = "GuidId";
            cmbGuid.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Location location = new Location();

            location.Capacity = byte.Parse(nudCapacity.Value.ToString());
            location.City = txtCity.Text;
            location.Country = txtCountry.Text;
            location.Price = decimal.Parse(txtPrice.Text);
            location.DayNight = txtDayNight.Text;
            location.GuidId = int.Parse(cmbGuid.SelectedValue.ToString());

            db.Location.Add(location);
            db.SaveChangesAsync();

            MessageBox.Show("Ekleme işlemi başarılı");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deletedValue = db.Location.Find(id);
            db.Location.Remove(deletedValue);
            db.SaveChangesAsync();

            MessageBox.Show("Silme işlemi başarılı");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updatedValue = db.Location.Find(id);

            updatedValue.DayNight = txtDayNight.Text;
            updatedValue.Price = decimal.Parse(txtPrice.Text);
            updatedValue.Capacity = byte.Parse(nudCapacity.Value.ToString());
            updatedValue.City = txtCity.Text;
            updatedValue.Country = txtCountry.Text;
            updatedValue.GuidId = int.Parse(cmbGuid.SelectedValue.ToString());
            db.SaveChangesAsync();

            MessageBox.Show("Güncelleme işlemi başarılı");
        }
    }
}
