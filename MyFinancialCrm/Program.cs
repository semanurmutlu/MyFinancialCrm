﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFinancialCrm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmDashboard());

            Application.Run(new FrmLogin()); //Başlangç ekranımı giriş ekranı olarak ayarladım.
            //Application.Run(new FrmSettings());
            //Application.Run(new FrmBanks());

        }
    }
}
