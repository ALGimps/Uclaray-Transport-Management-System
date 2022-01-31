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

namespace Uclaray_Transport_Management_System.Forms.Account_management
{
    public partial class frmAddUser : Form
    {
        private readonly frmAccountManagement parentForm;
        readonly RegexValidation Regex = new RegexValidation();
        public frmAddUser(frmAccountManagement frm)
        {
            InitializeComponent();
            parentForm = frm;
            ResetFields();
        }

        private void cboShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = cboShowPass.Checked ? '\0':'•';
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            txtFirst.Text = "testFirstname";
            txtLast.Text = "testLastname";
            txtUsername.Text = "testUsername";
            txtPassword.Text = "testPassword";
            cboRole.SelectedIndex = 0;
            txtContact.Text = "09123456789";
            txtEmail.Text = "tesEmail@email.com";

            if (!Regex.IsValid(txtFirst, @"^\S(?![\s.]+$)[a-zA-Z\s]*$", "Please enter a valid first name")) return;
            if (!Regex.IsValid(txtLast, @"^\S(?![\s.]+$)[a-zA-Z\s]*$", "Please enter a valid last name")) return;
            if (!Regex.IsValid(txtContact, @"^(09|\+639|639)\d{9}$", "Please enter a valid contact number")) return;
            if (!Regex.IsValid(txtEmail, @"/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/", "Please enter a valid email address")) return;
            if (cboRole.SelectedIndex < -1)
            {
                MessageBox.Show("Please select a role", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtUsername.TextLength < 4)
            {
                MessageBox.Show("Username must contain 4 characters or more", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Focus();
                return;
            }
            if (txtPassword.TextLength < 4)
            {
                MessageBox.Show("Password must contain 4 characters or more", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Focus();
                return;
            }
            if (txtConfirmPass.Text != txtPassword.Text)
            {
                MessageBox.Show("Password doesn't match", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtConfirmPass.Clear();
                txtConfirmPass.Focus();
                return;
            }

            UserAccount User = new UserAccount();
            string firstname = txtFirst.Text.Trim();
            string lastname = txtLast.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cboRole.Text.Trim();
            string contact = txtContact.Text.Trim();
            string email = txtEmail.Text.Trim();

            User.AddUserAccounts(username, password, email, role, firstname, lastname, contact);
            Close();
           parentForm.LoadData();
        }

        private void ResetFields()
        {
            txtFirst.Text = "";
            txtLast.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            cboRole.SelectedIndex = -1;
            txtContact.Text = "";
            txtEmail.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
