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
    public partial class frmResetPassword : Form
    {
        private readonly frmAccountManagement parentForm;
        private readonly UserAccount userAccount = new UserAccount();
        private UserAccount myUserAccount = new UserAccount();
        private int user_id;

        public frmResetPassword(frmAccountManagement frm,int id)
        {
            InitializeComponent();
            parentForm = frm;
            user_id = id;
            myUserAccount = userAccount.GetUser(user_id);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

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

            if (MessageBox.Show("Are you sure you want to reset the password for this user? \n This action cannot be undone","Confirm Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                string password = txtPassword.Text.Trim();
                userAccount.ResetPassword(user_id, password);
            }
        }

        private void frmResetPassword_Load(object sender, EventArgs e)
        {
            lblHeader.Text = "Reset Password for " + myUserAccount.userName;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = cboShowPass.Checked ? '\0' : '•';
        }
    }
}
