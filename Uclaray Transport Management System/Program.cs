﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Uclaray_Transport_Management_System
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
            //Application.Run(new Forms.Account_management.frmAccountManagement());
            //Application.Run(new Forms.Employee_management.frmEmployeeManagement());
            //Application.Run(new Forms.Record_Management.frmAdvancedTracking());
            //Application.Run(new Forms.Record_Management.frmAdvancedTracking());

            Forms.frmLogin LoginForm = new Forms.frmLogin();

            if (LoginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Forms.frmMain());
            }
            else
            {
                Application.Exit();
            }

            //Application.Run(new Forms.frmDashboard());

        }
    }
}
