using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFinancialCrm.Models;

namespace MyFinancialCrm
{
    public partial class FrmBankProcess : Form
    {
        public FrmBankProcess()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmBankProcess_Load(object sender, EventArgs e)
        {   // Sayfa açıldığında: Son işlemlerden 7 si sondan geriye listelensin istiyorum ve açıklama,tarih,tip ve tutar olarak gelsin
            var bankProcess1 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).FirstOrDefault();
            lblBankProcess1.Text = bankProcess1.Description + " / " + bankProcess1.ProcessDate + " / " + bankProcess1.ProcessType;
            lblBankProcessAmount1.Text = bankProcess1.Amount.ToString() + "₺";
            var bankProcess2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            lblBankProcess2.Text = bankProcess2.Description + " / " + bankProcess2.ProcessDate + " / " + bankProcess2.ProcessType;
            lblBankProcessAmount2.Text = bankProcess2.Amount.ToString() + "₺";
            var bankProcess3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            lblBankProcess3.Text = bankProcess3.Description + " / " + bankProcess3.ProcessDate + " / " + bankProcess3.ProcessType;
            lblBankProcessAmount3.Text = bankProcess3.Amount.ToString() + "₺";
            var bankProcess4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
            lblBankProcess4.Text = bankProcess4.Description + " / " + bankProcess4.ProcessDate + " / " + bankProcess4.ProcessType;
            lblBankProcessAmount4.Text = bankProcess4.Amount.ToString() + "₺";
            var bankProcess5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
            lblBankProcess5.Text = bankProcess5.Description + " / " + bankProcess5.ProcessDate + " / " + bankProcess5.ProcessType;
            lblBankProcessAmount5.Text = bankProcess5.Amount.ToString() + "₺";
            var bankProcess6 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(6).Skip(5).FirstOrDefault();
            lblBankProcess6.Text = bankProcess6.Description + " / " + bankProcess6.ProcessDate + " / " + bankProcess6.ProcessType;
            lblBankProcessAmount6.Text = bankProcess6.Amount.ToString() + "₺";
            var bankProcess7 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(7).Skip(6).FirstOrDefault();
            lblBankProcess7.Text = bankProcess7.Description + " / " + bankProcess7.ProcessDate + " / " + bankProcess7.ProcessType;
            lblBankProcessAmount7.Text = bankProcess7.Amount.ToString() + "₺";
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

        private void btnExpensesForm_Click(object sender, EventArgs e)
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
