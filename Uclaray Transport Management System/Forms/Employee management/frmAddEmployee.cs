using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Uclaray_Transport_Management_System.Classes;



namespace Uclaray_Transport_Management_System.Forms.Employee_management
{
    public partial class frmAddEmployee : Form
    {
        private readonly frmEmployeeManagement parentForm;
        readonly Employee employee = new Employee();
        readonly RegexValidation Regex = new RegexValidation();
        public frmAddEmployee(frmEmployeeManagement frm)
        {
            InitializeComponent();
            parentForm = frm;
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!Regex.IsValid(txtFirst, @"^\S(?![\s.]+$)[a-zA-Z\s]*$", "Please enter a valid first name")) return;
            if (!Regex.IsValid(txtLast, @"^\S(?![\s.]+$)[a-zA-Z\s]*$", "Please enter a valid last name")) return;
            if (cbDesignation.SelectedIndex < -1)
            {
                MessageBox.Show("Please select a designation", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!Regex.IsValid(txtContact, @"^(09|\+639|639)\d{9}$", "Please enter a valid contact number")) return;

            employee.addEmployee(txtFirst.Text, txtLast.Text, cbDesignation.Text, txtContact.Text);
            parentForm.LoadData();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
