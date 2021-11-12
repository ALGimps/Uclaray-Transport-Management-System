using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

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

        readonly static string SERVER = "localhost";
        readonly static string USERID = "root";
        readonly static string PASSWORD = "1234";
        readonly static string PORT = "3306";
        readonly static string DATABASE = "uclaray_product_tracking_management_system";

        //readonly static string SERVER = "db4free.net";
        //readonly static string USERID = "capstone_test";
        //readonly static string PASSWORD = "capstone_test";
        //readonly static string PORT = "3306";
        //readonly static string DATABASE = "capstone_test";

        static string connstring = $"SERVER= {SERVER}; USER ID= {USERID}; PASSWORD= {PASSWORD}; PORT= {PORT}; DATABASE= {DATABASE};";

        public List<UserAccount> GetUserAccounts()
        {
            List<UserAccount> userAccountsList = new List<UserAccount>();

            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();

            string query = "SELECT user_id, user_first, user_last, username, user_email, user_role FROM user_accounts";

            //Initialize command
            MySqlCommand comm = new MySqlCommand(query, conn);

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
            conn.Close();
            conn.Dispose();

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

            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();

            string query = "INSERT INTO user_accounts(username, hash, salt, user_email, user_role, user_first, user_last, user_contact) VALUES(?username, ?hash, ?salt, ?email, ?role, ?firstname, ?lastname, ?contact)";

            //Initialize Command
            MySqlCommand comm = new MySqlCommand(query, conn);
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
            conn.Close();
            conn.Dispose();
        }

        private bool UsernameExists(string username)
        {
            int userFound;
            using (MySqlConnection conn = new MySqlConnection(connstring))
            {
                conn.Open();

                string query = "SELECT COUNT(user_id) FROM user_accounts WHERE username=?username";

                //Initialize command
                MySqlCommand comm = new MySqlCommand(query, conn);
                comm.Parameters.AddWithValue("?username", username);

                //Execute
                userFound = Convert.ToInt32(comm.ExecuteScalar());
                conn.Close();
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
            int recordExist;
            using (MySqlConnection conn = new MySqlConnection(connstring))
            {
                conn.Open();

                string query = "SELECT COUNT(user_id) FROM user_accounts WHERE user_first=?firstname AND user_last=?lastname AND user_email=?email AND user_contact=?contact";

                //Initialize command
                MySqlCommand comm = new MySqlCommand(query, conn);
                comm.Parameters.AddWithValue("?firstname", firstName);
                comm.Parameters.AddWithValue("?lastname", lastName);
                comm.Parameters.AddWithValue("?email", email);
                comm.Parameters.AddWithValue("?contact", contact);

                //Execute
                recordExist = Convert.ToInt32(comm.ExecuteScalar());
                conn.Close();
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
