using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new ApplicationDbContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Username == userName);

                if (user != null && BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
                {
                    MessageBox.Show("Hoş geldiniz!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmDashboard frmDashboard = new FrmDashboard();
                    frmDashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegister frmRegister = new FrmRegister();
            frmRegister.Show();
            this.Hide();
        }
    }
}
