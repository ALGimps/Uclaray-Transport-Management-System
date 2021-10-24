using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Uvlaray_Transport_Management_System.Class
{
    class Employee
    {
        public void AddEmployee(string firstName, string lastName, string designation, string contact)
        {
            string SERVER = "localhost";
            string USERID = "root";
            string PASSWORD = "1234";
            string PORT = "3306";
            string DATABASE = "uclaray_product_tracking_management_system";

            string connstring = $"SERVER= {SERVER}; USER ID= {USERID}; PASSWORD= {PASSWORD}; PORT= {PORT}; DATABASE= {DATABASE};";
            MySqlConnection conn = new MySqlConnection(connstring);
            MySqlCommand comm= conn.CreateCommand();
            comm.CommandText= "INSERT INTO employees (emp_first, emp_last, emp_class, emp_contact) VALUES (?firstname, ?lastname, ?class, ?contact)";
            comm.Parameters.AddWithValue("?firstname", firstName);
            comm.Parameters.AddWithValue("?lastname", lastName);
            comm.Parameters.AddWithValue("?class", designation);
            comm.Parameters.AddWithValue("?contact", contact);
            comm.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }
    }
}
