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
    public partial class frmUpdateEmployee : Form
    {
        private readonly frmEmployeeManagement frm1;
        readonly Employee employee = new Employee();
        Employee myEmployee;
        public frmUpdateEmployee(frmEmployeeManagement frm, int id)
        {
            InitializeComponent();
            frm1 = frm;
            //fetch employee details from database
            myEmployee = employee.getEmployee(id);
        }

        private bool isRegexValidated(Control ctrl, String regex, String msg)
        {
            if (!Regex.Match(ctrl.Text, regex).Success)
            {
                MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ctrl.Focus();
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!isRegexValidated(txtfirst, @"^\S(?![\s.]+$)[a-zA-Z\s]*$", "Please enter a valid first name")) return;
            if (!isRegexValidated(txtlast, @"^\S(?![\s.]+$)[a-zA-Z\s]*$", "Please enter a valid last name")) return;
            if (!isRegexValidated(cbdesignation, @"^\S(?![\s.]+$)[a-zA-Z\s]*$", "Please select a designation")) return;
            if (!isRegexValidated(txtcontact, @"^(09|\+639|639)\d{9}$", "Please enter a valid contact number")) return;
            
            if (MessageBox.Show("Save changes?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                employee.updateEmployee(myEmployee.id, txtfirst.Text, txtlast.Text, cbdesignation.Text, txtcontact.Text);
                MessageBox.Show("Sucessfully updated", "Sucess", MessageBoxButtons.OK);
                frm1.loadData();
                this.Close();
            }

        }

        //Populate form with data from database
        private void loadData()
        {
            txtfirst.Text = myEmployee.firstName;
            txtlast.Text = myEmployee.lastName;
            cbdesignation.SelectedIndex = cbdesignation.FindStringExact(myEmployee.designation);
            txtcontact.Text = myEmployee.contact;
        }

        private void frmUpdateEmployee_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void frmReset_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
