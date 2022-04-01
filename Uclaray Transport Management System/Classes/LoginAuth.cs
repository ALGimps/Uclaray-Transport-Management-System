using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Uclaray_Transport_Management_System.Classes
{
    class LoginAuth
    {
        static string connstring;
        private MySqlConnection connection;

        private void Initialize()
        {
            connstring = DBUtils.connstring;
            connection = new MySqlConnection(connstring);
        }

        public LoginAuth()
        {
            Initialize();
        }

        public void Login(){
            using (connection)
            {
                connection.Open();
            }
        }
    }

}
