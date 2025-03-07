using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MyFinancialCrm.Models;

namespace MyFinancialCrm
{
    public partial class FrmSpending : Form
    {
        public FrmSpending()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        int count = 0;
        List<Spendings> spendingList;
        private void FrmSpending_Load(object sender, EventArgs e)
        {
            var totalSpending = db.Spendings.Sum(x => x.SpendingAmount);
            lblTotalSpendingAmount.Text = totalSpending.ToString() + "₺";

            var highspending = db.Spendings.Max(x => x.SpendingAmount);
            lblHigtSpendingAmount.Text = highspending.ToString();

            //var lastSpendingAmount = db.Spendings.OrderByDescending(x => x.SpendingId).Take(1).Select(y => y.SpendingAmount).FirstOrDefault();
            //lblCategorySpending.Text = lastSpendingAmount.ToString() + "₺";

            spendingList = db.Spendings.ToList();
            if (spendingList.Count > 0)
            {
                timer1.Interval = 2000;
                timer1.Start();
            }

            chart2.Series.Clear();
            var series = chart2.Series.Add("Harcamalar");
            series.ChartType = SeriesChartType.Pie;
            foreach (var item in spendingList)
            {
                series.Points.AddXY(item.SpendingTitle, item.SpendingAmount);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
            // bu kısımda giderimin neye ait olduğu ve hangi kategoriye ait olduğu gözüksün istiyorum 
            if (spendingList == null || spendingList.Count == 0)
                return;

            var currentSpending = spendingList[count % spendingList.Count];
            var category = db.Categories.Find(currentSpending.CategoryId);

            lblSpendingTitle.Text = currentSpending.SpendingTitle;
            lblCategorySpending.Text = category != null ? category.CategoryName : "Bilinmeyen Kategori";
            lblSpendingAmount.Text = currentSpending.SpendingAmount.ToString() + " ₺";

            count++;

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
            FrmSettings frm = new FrmSettings();
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Close();
        }

    }
}




