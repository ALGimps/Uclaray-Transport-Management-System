using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uclaray_Transport_Management_System.Classes;
using System.Text.RegularExpressions;

namespace Uclaray_Transport_Management_System.Forms.Employee_management
{
    public partial class frmUpdateEmployee : Form
    {
        private readonly frmEmployeeManagement frm1;
        private readonly Employee employee = new Employee();
        private Employee myEmployee;
        private readonly RegexValidation Regex = new RegexValidation();

        public frmUpdateEmployee(frmEmployeeManagement frm, int id)
        {
            InitializeComponent();
            frm1 = frm;
            //fetch employee details from database
            myEmployee = employee.getEmployee(id);
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!Regex.IsValid(txtfirst, @"^\S(?![\s.]+$)[a-zA-Z\s]*$", "Please enter a valid first name")) return;
            if (!Regex.IsValid(txtlast, @"^\S(?![\s.]+$)[a-zA-Z\s]*$", "Please enter a valid last name")) return;
            if (cbdesignation.SelectedIndex < -1)
            {
                MessageBox.Show("Please select a designation", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!Regex.IsValid(txtcontact, @"^(09|\+639|639)\d{9}$", "Please enter a valid contact number")) return;
            
            if (MessageBox.Show("Save changes?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                employee.updateEmployee(myEmployee.id, txtfirst.Text, txtlast.Text, cbdesignation.Text, txtcontact.Text);
                frm1.LoadData();
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
