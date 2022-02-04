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
    public partial class frmAccountManagement : Form
    {
        frmMain MainForm = new frmMain();
        UserAccount userAccount = new UserAccount();
        public frmAccountManagement()
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy").ToString();
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            string salt = SecurityUtils.GenerateSalt(64);
            string pwdHashed = SecurityUtils.HashPassword(password, salt, 1024, 64);

            txtHash.Text = pwdHashed;
            txtSalt.Text = salt;
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            string currentPass = txtHash.Text;
            string password = txtCompare.Text;
            string salt = txtSalt.Text;
            string pwdHashed = SecurityUtils.HashPassword(password, salt, 1024, 64);

            if (currentPass == pwdHashed) MessageBox.Show("Correct");
        }

        public void LoadData()
        {
            var userList = userAccount.GetUserAccounts();
            dgvUsers.Rows.Clear();
            
            foreach (var user in userList)
            {
                var rowIndex = dgvUsers.Rows.Add(new object[]
                {
                    user.id,
                    user.firstName,
                    user.lastName,
                    user.userName,
                    user.email,
                    user.userRole,
                    user.contact,
                    imageList1.Images[0],
                    imageList1.Images[1],
                    user.active ? imageList1.Images[2] : imageList1.Images[3],
                    user.active
                });
                dgvUsers.Rows[rowIndex].Cells[7].ToolTipText = "Update user information";
                dgvUsers.Rows[rowIndex].Cells[8].ToolTipText = "Reset password";
                var tooltip = user.active ? "Deactivate user" : "Activate user";
                dgvUsers.Rows[rowIndex].Cells[9].ToolTipText = tooltip;
            }
        }
        private void frmAccountManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUser frm = new frmAddUser(this);
            frm.ShowDialog();
        }

        private void ShowUpdateForm()
        {
            var id = dgvUsers.SelectedCells[0].Value;
            frmUpdateUser frm = new frmUpdateUser(this, (int)id);
            frm.ShowDialog();
        } 

        private void ShowResetPasswordForm()
        {
            var id = dgvUsers.SelectedCells[0].Value;
            frmResetPassword frm = new frmResetPassword(this,(int)id);
            frm.ShowDialog();
        }

        private void ChangeUserStatus()
        {
            var username = dgvUsers.SelectedCells[3].Value.ToString();
            var userID = dgvUsers.SelectedCells[0].Value;
            if (Convert.ToBoolean(dgvUsers.SelectedCells[10].Value))
            {
                if (MessageBox.Show("Do you want to Deactivate user: " + username, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    userAccount.ChangeStatus(Convert.ToInt32(userID), 0);
                }
            }
            else
            {
                if (MessageBox.Show("Do you want to Deactivate user: " + username, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    userAccount.ChangeStatus(Convert.ToInt32(userID), 1);
                }
            }

            LoadData();
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsers.Columns[e.ColumnIndex].Index == 7)
            {
                ShowUpdateForm();
            }
            if (dgvUsers.Columns[e.ColumnIndex].Index == 8)
            {
                
                ShowResetPasswordForm();
            }
            if (dgvUsers.Columns[e.ColumnIndex].Index == 9)
            {
                ChangeUserStatus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hash = txthash1.Text;
            string salt = txtsalt1.Text;
            txtresult.Text = SecurityUtils.HashPassword(hash, salt, 1024, 64);
        }
    }
}
