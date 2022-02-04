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
    public partial class frmUpdateUser : Form
    {
        private readonly frmAccountManagement parentForm;
        private readonly RegexValidation Regex = new RegexValidation();
        private readonly UserAccount userAccount = new UserAccount();
        private UserAccount myUserAccount;
        private int id;

        public frmUpdateUser(frmAccountManagement frm, int userID)
        {
            InitializeComponent();
            parentForm = frm;
            id = userID;
            //fetch user details from database
            myUserAccount = userAccount.GetUser(userID);
        }

        private void loadData()
        {
            txtFirst.Text = myUserAccount.firstName;
            txtLast.Text = myUserAccount.lastName;
            txtEmail.Text = myUserAccount.email;
            txtContact.Text = myUserAccount.contact;
            txtUsername.Text = myUserAccount.userName;
            cboRole.SelectedIndex = cboRole.FindStringExact(myUserAccount.userRole);
        }

        private void frmUpdateUser_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!Regex.IsValid(txtFirst, @"^\S(?![\s.]+$)[a-zA-Z\s]*$", "Please enter a valid first name")) return;
            if (!Regex.IsValid(txtLast, @"^\S(?![\s.]+$)[a-zA-Z\s]*$", "Please enter a valid last name")) return;
            if (!Regex.IsValid(txtContact, @"^(09|\+639|639)\d{9}$", "Please enter a valid contact number")) return;
            if (!Regex.IsValid(txtEmail, @"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$", "Please enter a valid email address")) return;
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

            string firstname = txtFirst.Text.Trim();
            string lastname = txtLast.Text.Trim();
            string username = txtUsername.Text.Trim();
            string role = cboRole.Text.Trim();
            string contact = txtContact.Text.Trim();
            string email = txtEmail.Text.Trim();

            userAccount.UpdateUser(id, firstname, lastname, email, contact, role, username);
            parentForm.LoadData();
            Close();
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
