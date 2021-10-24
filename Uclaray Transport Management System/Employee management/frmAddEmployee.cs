using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uclaray_Transport_Management_System.Class;
using System.Text.RegularExpressions;

namespace Uclaray_Transport_Management_System.Employee_management
{
    public partial class frmAddEmployee : Form
    {
        private readonly frmEmployeeManagement frm1;
        public frmAddEmployee(frmEmployeeManagement frm)
        {
            InitializeComponent();
            frm1 = frm;
        }

        private bool isRegexValidated(Control ctrl, String regex, String msg)
        {
            if (!Regex.Match(ctrl.Text, regex).Success)
            {
                MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrl.Focus();
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (!isRegexValidated(txtfirst, @"^\S(?![\s.]+$)[a-zA-Z\s]*$", "Invalid first name")) return;
            if (!isRegexValidated(txtlast, @"^\S(?![\s.]+$)[a-zA-Z\s]*$", "Invalid last name")) return;
            if (!isRegexValidated(cbdesignation, @"^\S(?![\s.]+$)[a-zA-Z\s]*$", "Invalid designation")) return;
            if (!isRegexValidated(txtcontact, @"^(09|\+639|639)\d{9}$", "Invalid contact number")) return;


            //if (!Regex.Match(txtcontact.Text, @"^(09|\+639|639)\d{9}$").Success)
            //{
            //    MessageBox.Show("Invalid contact number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtcontact.Focus();
            //    return;
            //}

            Employee Employee = new Employee();
            Employee.AddEmployee(txtfirst.Text, txtlast.Text, cbdesignation.Text, txtcontact.Text);
            MessageBox.Show("success");
            frm1.loadData();
            this.Close();
        }
    }
}
