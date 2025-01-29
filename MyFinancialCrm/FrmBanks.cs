using MyFinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFinancialCrm
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }
        FinancialDbEntities1 db = new FinancialDbEntities1();
        private void FrmBanks_Load(object sender, EventArgs e)
        {
            //BANKA BAKİYELERİ
            var ziraatBankBalance = db.Banks.Where(x => x.BankTitle == "Ziraat Bankası")
                .Select(y => y.BankBalance).FirstOrDefault();
            var vakifBankBalance = db.Banks.Where(x => x.BankTitle == "Vakıfbank")
                .Select(y => y.BankBalance).FirstOrDefault();
            var isBankasiBalance = db.Banks.Where(x => x.BankTitle == "İş Bankası")
                .Select(y => y.BankBalance).FirstOrDefault();

            lblZiraatBankBalance.Text = ziraatBankBalance.ToString() + " ₺";
            lblVakifbankBalance.Text = vakifBankBalance.ToString() + " ₺";
            lblIsBankasiBalance.Text = isBankasiBalance.ToString() + " ₺";

            //BANKA HAREKETLERİ
            var bankProcess1 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).FirstOrDefault();
            lblBankProcess1.Text = bankProcess1.Description + " / " + bankProcess1.ProcessDate + " / " + bankProcess1.ProcessType + " / " + bankProcess1.Amount+"₺";

            var bankProcess2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            lblBankProcess2.Text= bankProcess2.Description + " / " + bankProcess2.ProcessDate + " / " + bankProcess2.ProcessType + " / " + bankProcess2.Amount + "₺";

            var bankProcess3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            lblBankProcess3.Text = bankProcess3.Description + " / " + bankProcess3.ProcessDate + " / " + bankProcess3.ProcessType + " / " + bankProcess3.Amount + "₺";

            var bankProcess4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
            lblBankProcess4.Text = bankProcess4.Description + " / " + bankProcess4.ProcessDate + " / " + bankProcess4.ProcessType + " / " + bankProcess4.Amount + "₺";

            var bankProcess5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
            lblBankProcess5.Text = bankProcess5.Description + " / " + bankProcess5.ProcessDate + " / " + bankProcess5.ProcessType + " / " + bankProcess5.Amount + "₺";

        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm=new FrmBilling();
            frm.Show();
            this.Hide();
        }
    }
}
