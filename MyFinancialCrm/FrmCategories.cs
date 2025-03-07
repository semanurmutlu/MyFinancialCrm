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
    public partial class FrmCategories : Form
    {

        public FrmCategories()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            var value = db.Categories.ToList();
            dataGridView1.DataSource = value;
        }

        private void btnCategoryList_Click(object sender, EventArgs e)
        {
            var value = db.Categories.ToList();
            dataGridView1.DataSource = value;
        }

        private void btnCreateCategory_Click(object sender, EventArgs e)
        {
            string title = txtCategoryTitle.Text;

            Categories categories = new Categories();
            categories.CategoryName = title;

            db.Categories.Add(categories);
            db.SaveChanges();
            MessageBox.Show("Kategori Ekleme İşleminiz Başarılı Bir Şekilde Gerçekleşmiştir.", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var value = db.Categories.ToList();
            dataGridView1.DataSource = value;
        }

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var removeValue = db.Categories.Find(id);
            db.Categories.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Kategori Silme İşleminiz Başarılı Bir Şekilde Gerçekleşmiştir!", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var value = db.Categories.ToList();
            dataGridView1.DataSource = value;
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var updateValue = db.Categories.Find(id);
            updateValue.CategoryName = txtCategoryTitle.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Güncelleme İşleminiz Başarılı Bir Şekilde Gerçekleşmirtir!", "Kategori", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var value = db.Categories.ToList();
            dataGridView1.DataSource = value;
        }

        private void btnCategoryForm_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
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
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnSettingsFrm_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
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
