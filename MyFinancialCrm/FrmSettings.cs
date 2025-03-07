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
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            var username = db.Users.FirstOrDefault();
           // lblCurrentPassword.Text = username.UserName;
            txtCurrentPassword.PasswordChar='*';
            txtNewPassword.PasswordChar = '*';
        }

        private void btnPasswordUpdate_Click(object sender, EventArgs e)
        {
            var user = db.Users.FirstOrDefault();
            string currentPassword=txtCurrentPassword.Text;
            string newPassword=txtNewPassword.Text;

            if (currentPassword == user.Password)
            {
                user.Password = newPassword;
                db.SaveChanges();
                MessageBox.Show("Şifreniz Güncellendi!");
            }
            else
            {
                MessageBox.Show("Mevcut Şifrenizi Hatalı Girdiniz.");
            }
        }

        private void btnCategoryForm_Click(object sender, EventArgs e)
        {
            FrmCategories frm= new FrmCategories();
            frm.Show();
            this.Hide();
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void btnBillsForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void btnSpendingForm_Click(object sender, EventArgs e)
        {
            FrmSpending frm = new FrmSpending();
            frm.Show();
            this.Hide();
        }

        private void btnBankProccesForm_Click(object sender, EventArgs e)
        {
            FrmBankProcess frm = new FrmBankProcess();
            frm.Show();
            this.Hide();
        }

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard frm=new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Close();  
        }

    }
}
