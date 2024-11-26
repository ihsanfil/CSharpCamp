using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCamp301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
        CSharpCampTravelEfDbEntities1 db = new CSharpCampTravelEfDbEntities1();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            

            var locationCount = db.Location.Count();
            lblLocationCount.Text = locationCount.ToString();
            lblSumCapacity.Text = db.Location.Sum(x=>x.Capacity).ToString();
            lblGuidCount.Text = db.Guid.Count().ToString();
            
            lblAvgCapacity.Text = ((double)db.Location.Average(x => x.Capacity)).ToString("F2");
            //Ortalama tur fiyatı
            var avgLocationPrice = ((double)db.Location.Average(x => x.Price)).ToString("C2", new CultureInfo("tr-TR"));
            lblAvgLocationPrice.Text = avgLocationPrice;
           
            int lastCountryId = db.Location.Max(x => x.LocationId);
            lblLastCountryName.Text = db.Location.Where(x => x.LocationId == lastCountryId).Select(x => x.Country).FirstOrDefault();
            lblCappadociaLocationCapacity.Text = db.Location.Where(x => x.City == "Kapadokya").Select(x => x.Capacity).FirstOrDefault().ToString();
            lblTrCapacity.Text = db.Location.Where(x => x.Country == "Türkiye").Average(x => x.Capacity).ToString();
            var romeGuidId= db.Location.Where(x=>x.City == "Roma").Select(x=>x.GuidId).FirstOrDefault();
            lblRomeGuidName.Text = db.Guid.Where(x => x.GuidId == romeGuidId).Select(x => x.Name+ " " +x.Surname).FirstOrDefault();

            var maximumCapactiy = db.Location.Max(x=>x.Capacity);
            lblMaxCapacityLocation.Text = db.Location.Where(x=>x.Capacity == maximumCapactiy).Select(x=>x.City).FirstOrDefault().ToString();


            var maximumPriceTour = db.Location.Max(x => x.Price);
            lblmaxpricelocation.Text = db.Location.Where(x => x.Price == maximumPriceTour).Select(x => x.City).FirstOrDefault().ToString();
            var serdarGuidId = db.Guid.Where(x => x.Name == "Serdar" && x.Surname == "Sevinti").Select(x => x.GuidId).FirstOrDefault();
            var serdarTourCount = db.Location.Where(x => x.GuidId == serdarGuidId).Count();
            lblSerdarTourCount.Text = serdarTourCount.ToString();
        
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lblAvgLocationPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
