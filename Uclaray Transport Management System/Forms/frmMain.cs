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
using MySql.Data.MySqlClient;
using Uclaray_Transport_Management_System.Classes;

namespace Uclaray_Transport_Management_System.Forms
{
    public partial class frmMain : Form
    {
        static string connstring;
        private MySqlConnection connection;
        public frmMain()
        {
            InitializeComponent();
            InitializeUser();
            
        }

        void InitializeUser()
        {
            connstring = DBUtils.connstring;
            connection = new MySqlConnection(connstring);
            string userRole;

            using (connection)
            {
                connection.Open();

                string query = "SELECT user_first, user_last, user_role FROM user_accounts WHERE user_id=?UserId";

                //Initialize command
                MySqlCommand comm = new MySqlCommand(query, connection);
                comm.Parameters.AddWithValue("?UserId", UtilityClass.UserId);
                //Execute Data reader
                MySqlDataReader dr = comm.ExecuteReader();

                    while (dr.Read())
                    {
                    lblName.Text = dr[0] + " " + dr[1];
                    userRole = dr[2].ToString();

                    }
            }
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

            foreach(object obj in flpNav.Controls)
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

        private void btnCurrentDelivery_Click(object sender, EventArgs e)
        {
            Record_Management.frmCurrentDeliveries frm = new Record_Management.frmCurrentDeliveries();
            Showform(frm, (Guna2Button)sender);
        }

        private void btnAdvancedTracking_Click(object sender, EventArgs e)
        {
            Record_Management.frmAdvancedTrackingv2 frm = new Record_Management.frmAdvancedTrackingv2();
            Showform(frm, (Guna2Button)sender);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Record_Management.frmSuccessfulDeliveries frm = new Record_Management.frmSuccessfulDeliveries();
            Showform(frm, (Guna2Button)sender);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Record_Management.frmBadOrders frm = new Record_Management.frmBadOrders();
            Showform(frm, (Guna2Button)sender);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Record_Management.frmHistory frm = new Record_Management.frmHistory();
            Showform(frm, (Guna2Button)sender);
        }
    }
}
