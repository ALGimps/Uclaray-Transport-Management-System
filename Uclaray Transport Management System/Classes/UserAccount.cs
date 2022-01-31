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
        public string userName { get; set; }
        [System.ComponentModel.DisplayName("Email")]
        public string email { get; set; }
        [System.ComponentModel.DisplayName("Role")]
        public string userRole { get; set; }

        //Define connection string

        static string SERVER;
        static string USERID;
        static string PASSWORD;
        static string PORT;
        static string DATABASE;

        //static string SERVER = "db4free.net";
        //static string USERID = "capstone_test";
        //static string PASSWORD = "capstone_test";
        //static string PORT = "3306";
        //static string DATABASE = "capstone_test";

        static string connstring;
        private MySqlConnection connection;

        private void Initialize()
        {
            SERVER = "localhost";
            USERID = "root";
            PASSWORD = "1234";
            PORT = "3306";
            DATABASE = "uclaray_product_tracking_management_system";
            connstring = $"SERVER= {SERVER}; USER ID= {USERID}; PASSWORD= {PASSWORD}; PORT= {PORT}; DATABASE= {DATABASE};";
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

            string query = "SELECT user_id, user_first, user_last, username, user_email, user_role FROM user_accounts";

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
                        userRole = dr["user_role"].ToString()
                    };
                    userAccountsList.Add(user);
                }
                CloseConnection();
            }
            return userAccountsList;
        }

        public void AddUserAccounts(string username, string password, string email, string role, string firstName, string lastName, string contact)
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

            string query = "INSERT INTO user_accounts(username, hash, salt, user_email, user_role, user_first, user_last, user_contact) VALUES(?username, ?hash, ?salt, ?email, ?role, ?firstname, ?lastname, ?contact)";

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

    }

}
