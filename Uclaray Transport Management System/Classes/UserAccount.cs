using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Uclaray_Transport_Management_System.Classes
{
    class UserAccount
    {
        [System.ComponentModel.DisplayName("ID")]
        public int id { get; set; }
        [System.ComponentModel.DisplayName("First name")]
        public string firstName { get; set; }
        [System.ComponentModel.DisplayName("Last name")]
        public string lastName { get; set; }
        [System.ComponentModel.DisplayName("User name")]

        public string fullName { get { return firstName + " " + lastName; } set { } }
        public string userName { get; set; }
        [System.ComponentModel.DisplayName("Email")]
        public string email { get; set; }
        [System.ComponentModel.DisplayName("Role")]
        public string userRole { get; set; }
        public string contact { get; set; }
        public bool active { get; set; }

        static string connstring;
        private MySqlConnection connection;

        private void Initialize()
        {
            connstring = DBUtils.connstring;
            connection = new MySqlConnection(connstring);
        }

        public UserAccount()
        {
            Initialize();
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public List<UserAccount> GetUserAccounts()
        {
            List<UserAccount> userAccountsList = new List<UserAccount>();

            string query = "SELECT user_id, user_first, user_last, username, user_email, user_role,user_contact, active FROM user_accounts";

            if (OpenConnection())
            {

                //Initialize command
                MySqlCommand comm = new MySqlCommand(query, connection);

                //Execute Data reader
                MySqlDataReader dr = comm.ExecuteReader();

                //Populate List with data
                while (dr.Read())
                {
                    UserAccount user = new UserAccount
                    {
                        id = (int)dr["user_id"],
                        firstName = dr["user_first"].ToString(),
                        lastName = dr["user_last"].ToString(),
                        userName = dr["username"].ToString(),
                        email = dr["user_email"].ToString(),
                        userRole = dr["user_role"].ToString(),
                        contact = dr["user_contact"].ToString(),
                        active = Convert.ToBoolean(dr["active"])
                };
                    userAccountsList.Add(user);
                }
                CloseConnection();
            }
            return userAccountsList;
        }

        public UserAccount GetUser(int id)
        {
            UserAccount userAccount = new UserAccount();

            string query = "SELECT user_id, user_first, user_last, username, user_email, user_role,user_contact, active FROM user_accounts WHERE user_id=?id";

            if (OpenConnection())
            {

                //Initialize command
                MySqlCommand comm = new MySqlCommand(query, connection);
                comm.Parameters.AddWithValue("?id", id);
                //Execute Data reader
                MySqlDataReader dr = comm.ExecuteReader();

                //Populate List with data
                while (dr.Read())
                {
                    userAccount.id = (int)dr["user_id"];
                    userAccount.firstName = dr["user_first"].ToString();
                    userAccount.lastName = dr["user_last"].ToString();
                    userAccount.userName = dr["username"].ToString();
                    userAccount.email = dr["user_email"].ToString();
                    userAccount.userRole = dr["user_role"].ToString();
                    userAccount.contact = dr["user_contact"].ToString();
                    userAccount.active = Convert.ToBoolean(dr["active"]);
                }
                CloseConnection();
            }
            return userAccount;
        }

        public void AddUser(string username, string password, string email, string role, string firstName, string lastName, string contact)
        {
            //Check if record exist
            if (RecordExists(firstName, email, lastName, contact))
            {
                System.Windows.Forms.MessageBox.Show("Record already exist", "Failed", System.Windows.Forms.MessageBoxButtons.OK);
                return;
            }
            if (UsernameExists(username))
            {
                System.Windows.Forms.MessageBox.Show("Username already used", "Failed", System.Windows.Forms.MessageBoxButtons.OK);
                return;
            }

            //Generate random salt and Hash password
            var salt = SecurityUtils.GenerateSalt(64);
            var hash = SecurityUtils.HashPassword(password, salt, 1024, 64);

            string query = "INSERT INTO user_accounts(username, hash, salt, user_email, user_role, user_first, user_last, user_contact,active) VALUES(?username, ?hash, ?salt, ?email, ?role, ?firstname, ?lastname, ?contact,?active)";

            if (OpenConnection())
            {

                //Initialize Command
                MySqlCommand comm = new MySqlCommand(query, connection);
                comm.Parameters.AddWithValue("?username", username);
                comm.Parameters.AddWithValue("?hash", hash);
                comm.Parameters.AddWithValue("?salt", salt);
                comm.Parameters.AddWithValue("?email", email);
                comm.Parameters.AddWithValue("?role", role);
                comm.Parameters.AddWithValue("?firstname", firstName);
                comm.Parameters.AddWithValue("?lastname", lastName);
                comm.Parameters.AddWithValue("?contact", contact);
                comm.Parameters.AddWithValue("?active", 1);

                //Execute
                comm.ExecuteNonQuery();
                CloseConnection();
            }
        }

        private bool UsernameExists(string username)
        {
            int userFound=0;
            string query = "SELECT COUNT(user_id) FROM user_accounts WHERE username=?username";

            if (OpenConnection())
            {

                //Initialize command
                MySqlCommand comm = new MySqlCommand(query, connection);
                comm.Parameters.AddWithValue("?username", username);

                //Execute
                userFound = Convert.ToInt32(comm.ExecuteScalar());
                CloseConnection();
            }

            if (userFound > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool RecordExists(string firstName, string lastName, string email, string contact)
        {
            int recordExist=0;

            string query = "SELECT COUNT(user_id) FROM user_accounts WHERE user_first=?firstname AND user_last=?lastname AND user_email=?email AND user_contact=?contact";

            if (OpenConnection())
            {
                //Initialize command
                MySqlCommand comm = new MySqlCommand(query, connection);
                comm.Parameters.AddWithValue("?firstname", firstName);
                comm.Parameters.AddWithValue("?lastname", lastName);
                comm.Parameters.AddWithValue("?email", email);
                comm.Parameters.AddWithValue("?contact", contact);

                //Execute
                recordExist = Convert.ToInt32(comm.ExecuteScalar());
            CloseConnection();
            }


            if (recordExist > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void ResetPassword(int id,string newPassword)
        {

            //Generate random salt and Hash password
            var salt = SecurityUtils.GenerateSalt(64);
            var hash = SecurityUtils.HashPassword(newPassword, salt, 1024, 64);

            string query = "UPDATE user_accounts SET hash = ?hash, salt = ?salt WHERE user_id = ?id";

            if (OpenConnection())
            {
                //Initialize command
                MySqlCommand comm = new MySqlCommand(query, connection);
                comm.Parameters.AddWithValue("?hash", hash);
                comm.Parameters.AddWithValue("?salt", salt);
                comm.Parameters.AddWithValue("?id", id);

                //Execute
                comm.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public void UpdateUser(int id, string firstname, string lastname, string email, string contact, string role, string username)
        {
            string query = "UPDATE user_accounts SET username = ?username, user_email = ?email, user_role = ?role, user_first = ?firstname, user_last = ?lastname, user_contact = ?contact WHERE user_id = ?id";

            if (OpenConnection())
            {

                //Initialize Command
                MySqlCommand comm = new MySqlCommand(query, connection);
                comm.Parameters.AddWithValue("?username", username);
                comm.Parameters.AddWithValue("?email", email);
                comm.Parameters.AddWithValue("?role", role);
                comm.Parameters.AddWithValue("?firstname", firstname);
                comm.Parameters.AddWithValue("?lastname", lastname);
                comm.Parameters.AddWithValue("?contact", contact);
                comm.Parameters.AddWithValue("?id", id);

                //Execute
                comm.ExecuteNonQuery();
                CloseConnection();
                MessageBox.Show("Successfully updated");
            }
        }

        public void ChangeStatus(int id,int newStatus)
        {
            string query = "UPDATE user_accounts SET active = ?active WHERE user_id = ?id";

            if (OpenConnection())
            {
                //Initialize command
                MySqlCommand comm = new MySqlCommand(query, connection);
                comm.Parameters.AddWithValue("?active", newStatus);
                comm.Parameters.AddWithValue("?id", id);

                //Execute
                comm.ExecuteNonQuery();
                CloseConnection();
            }
        }
    }

}
