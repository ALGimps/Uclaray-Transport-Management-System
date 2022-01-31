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

        public frmAccountManagement()
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy").ToString();
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            string salt = SecurityUtils.GenerateSalt(32);
            string pwdHashed = SecurityUtils.HashPassword(password, salt, 1010, 32);

            txtHash.Text = pwdHashed;
            txtSalt.Text = salt;
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            string currentPass = txtHash.Text;
            string password = txtCompare.Text;
            string salt = txtSalt.Text;
            string pwdHashed = SecurityUtils.HashPassword(password, salt, 1010, 32);

            if (currentPass == pwdHashed) MessageBox.Show("Correct");
        }

        public void LoadData()
        {
            UserAccount userAccount = new UserAccount();
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
                    imageList1.Images[0]
                });
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

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsers.Columns[e.ColumnIndex].Index == 6)
            {
                var location = dgvUsers.PointToScreen(dgvUsers.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location);
                panelActions.BringToFront();
                panelActions.Location = new Point(location.X - (224 + panelActions.Width), location.Y  - 225);
                //MessageBox.Show(panelActions.Location.ToString());
                panelActions.Visible = true;
                panelActions.Focus();
            }
            else
            {
                panelActions.Visible = false;
            }
        }

        private void panelActions_Leave(object sender, EventArgs e)
        {
            panelActions.Visible = false;
        }
    }
}
