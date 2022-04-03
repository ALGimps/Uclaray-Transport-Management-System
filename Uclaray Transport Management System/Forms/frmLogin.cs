using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Uclaray_Transport_Management_System.Classes;

namespace Uclaray_Transport_Management_System.Forms
{
    public partial class frmLogin : Form
    {

        static string connstring;
        private MySqlConnection connection;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //txtUsername.Text = "admintest";
            //txtPassword.Text = "admintest";
            //btnLogin_Click(sender, e);
        }

        private void cboShowPass_CheckedChanged(object sender, EventArgs e)
        {
                txtPassword.PasswordChar = cboShowPass.Checked ? '\0' : '•';
        }


        string userName;
        string password;
        int userId = 0;
        string salt = "", hash = "";
        bool userNameFound = false;
        bool userMatch = false;


        private async void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("Please enter your Username");
                txtUsername.BorderColor = Color.Red;
                return;
            }

            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please enter your Password");
                txtPassword.BorderColor = Color.Red;
                return;
            }

            btnLogin.Enabled = false;
            userName = txtUsername.Text.Trim();
            password = txtPassword.Text.Trim();


            //connstring = DBUtils.connstring;
            //connection = new MySqlConnection(connstring);
            //using (connection)
            //{
            //    connection.Open();

            //    string query = "SELECT user_id, salt, hash FROM user_accounts WHERE username=?username";

            //    //Initialize command
            //    MySqlCommand comm = new MySqlCommand(query, connection);
            //    comm.Parameters.AddWithValue("?username", userName);
            //    //Execute Data reader
            //    MySqlDataReader dr = comm.ExecuteReader();

            //    if (dr.HasRows)
            //    {
            //        userNameFound = true;
            //        while (dr.Read())
            //        {

            //            userId = (int)dr[0];
            //            salt = dr[1].ToString();
            //            hash = dr[2].ToString();
            //        }
            //    }

            //}

            await Task.Run(() => (userNameFound = VerifyLogin(userName,password)));

            btnLogin.Enabled = true;

            if (userNameFound)
            {
                string enteredHash = SecurityUtils.GenerateHash(password, salt);
                if (hash == enteredHash)
                {
                    userMatch=true;
                    User.UserId = userId;
                }

            }
            else
            {
                MessageBox.Show("Username not found");
                txtUsername.BorderColor = Color.Red;
                userMatch = false;
            }

            if (userMatch)
            {
                this.DialogResult = DialogResult.OK;
                //frmMain frm = new frmMain();
                //frm.Show();
                Close();
            }
            else
            {
                txtPassword.Clear();
                MessageBox.Show("Password and Username doesn't match");
            }

        }



        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            txtUsername.BorderColor = Color.FromArgb(213, 218, 223);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.BorderColor = Color.FromArgb(213, 218, 223);
        }

        private bool VerifyLogin(string userName, string Password)
        {
            connstring = DBUtils.connstring;
            connection = new MySqlConnection(connstring);
            using (connection)
            {
                connection.Open();

                string query = "SELECT user_id, salt, hash FROM user_accounts WHERE username=?username";

                //Initialize command
                MySqlCommand comm = new MySqlCommand(query, connection);
                comm.Parameters.AddWithValue("?username", userName);
                //Execute Data reader
                MySqlDataReader dr = comm.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {

                        userId = (int)dr[0];
                        salt = dr[1].ToString();
                        hash = dr[2].ToString();
                    }
                    return true;
                }

            }
            return false;
        }

    }
}
