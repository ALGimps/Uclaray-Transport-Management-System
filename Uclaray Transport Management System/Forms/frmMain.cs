using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Uclaray_Transport_Management_System.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Showform(Form frm, Guna2Button button)
        {
            if (panelContainer.Contains(frm)) MessageBox.Show("ok");
            if (!panelContainer.Contains(frm)){
                panelContainer.Controls.Clear();
                frm.TopLevel = false;
                panelContainer.Controls.Add(frm);
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Show();
            }

            foreach(object obj in panelSidebar.Controls)
            {
                if (obj is Guna2Button)
                {
                    var b = (Guna2Button)obj;
                    b.FillColor = Color.White;
                }

            }
            button.FillColor = Color.LightGray;

        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            Employee_management.frmEmployeeManagement frm = new Employee_management.frmEmployeeManagement();
            Showform(frm,(Guna2Button)sender);
        }

        private void btnUserAccounts_Click(object sender, EventArgs e)
        {
            Account_management.frmAccountManagement frm = new Account_management.frmAccountManagement();
            Showform(frm, (Guna2Button)sender);
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            Logistics_partner_management.frmPartnerCompanies frm = new Logistics_partner_management.frmPartnerCompanies();
            Showform(frm, (Guna2Button)sender);
        }
    }
}
