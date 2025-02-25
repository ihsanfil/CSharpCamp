using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class FrmBilldig : Form
    {
        public FrmBilldig()
        {
            InitializeComponent();
        }

        private void FrmBilldig_Load(object sender, EventArgs e)
        {
            //var values = db.Bills.ToList(); 
            //dataGridView1.DataSource = values;

        }
        private ApplicationDbContext db = new ApplicationDbContext();
        private void button10_Click(object sender, EventArgs e)
        {
            string title = txtBillTitle.Text;
            decimal amount = decimal.Parse(txtBillAmount.Text);
            string period = txtBillPeriot.Text;
            Bill bills = new Bill();
            bills.BillTitle = title;
            bills.BillAmount = amount;
            bills.BillPeriod = period;
            db.Bills.Add(bills);
            db.SaveChanges();

            MessageBox.Show("Ödeme başarılı bir şekilde sisteme eklendi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnBillList_Click(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnRemoveBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBillId.Text);
            var removeValue = db.Bills.Find(id);
            db.Bills.Remove(removeValue);
            db.SaveChanges();

            MessageBox.Show("Ödeme başarılı bir şekilde sistemden silindi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBillId.Text);
            var value = db.Bills.Find(id);

            value.BillTitle = txtBillTitle.Text;
            value.BillAmount = decimal.Parse(txtBillAmount.Text);
            value.BillPeriod = txtBillPeriot.Text;

            db.SaveChanges();

            MessageBox.Show("Ödeme başarılı bir şekilde güncellendi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
            this.Hide();

        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmBilldig frmBilldig = new FrmBilldig();
            frmBilldig.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
