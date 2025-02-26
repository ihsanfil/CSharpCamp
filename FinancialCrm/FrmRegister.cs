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
    public partial class FrmRegister : Form
    {

        public FrmRegister()
        {
            InitializeComponent();
    
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var userNameOrEmail = txtUserName.Text;
            var userPassword = txtPassword.Text;
            var userEmail = txtUserName.Text;

            if (string.IsNullOrWhiteSpace(userNameOrEmail) || string.IsNullOrWhiteSpace(userPassword) || string.IsNullOrWhiteSpace(userEmail))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new ApplicationDbContext())
            {
                var existingUser = context.Users.FirstOrDefault(u => u.Username == userNameOrEmail || u.Email == userEmail);

                if (existingUser != null)
                {
                    MessageBox.Show("Bu kullanıcı adı veya e-posta zaten mevcut.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var hashedPassword = BCrypt.Net.BCrypt.HashPassword(userPassword);

                var user = new User
                {
                    Username = userNameOrEmail,
                    PasswordHash = hashedPassword,
                    Email = userEmail,
                    CreatedAt = DateTime.Now
                };

                context.Users.Add(user);
                context.SaveChanges();

                MessageBox.Show("Kayıt başarıyla tamamlandı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Kayıt başarılıysa formu kapat
            }
        }
    }
}
