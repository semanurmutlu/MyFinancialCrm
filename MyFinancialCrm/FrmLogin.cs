using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFinancialCrm.Models;

namespace MyFinancialCrm
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // sayfada şifre girildiğinde * olarak gösterilsin istiyorum...
            txtPassword.PasswordChar = '*'; 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            var user = db.Users.FirstOrDefault(x=>x.UserName == userName && x.Password == password);

            if (user != null)
            {
                MessageBox.Show("Giriş başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmBanks frmBanks = new FrmBanks();
                frmBanks.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre hatalı!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
