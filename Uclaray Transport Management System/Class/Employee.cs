using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Uclaray_Transport_Management_System.Class
{
    class Employee
    {

        public string id { get; set; }
        [System.ComponentModel.DisplayName("First name")]
        public string firstName { get; set; }
        [System.ComponentModel.DisplayName("Last name")]
        public string lastName { get; set; }
        [System.ComponentModel.DisplayName("Designation")]
        public string designation { get; set; }
        [System.ComponentModel.DisplayName("Contact")]
        public string contact { get; set; }

        static string SERVER = "localhost";
        static string USERID = "root";
        static string PASSWORD = "1234";
        static string PORT = "3306";
        static string DATABASE = "uclaray_product_tracking_management_system";

        public void AddEmployee(string firstName, string lastName, string designation, string contact)
        {


            string connstring = $"SERVER= {SERVER}; USER ID= {USERID}; PASSWORD= {PASSWORD}; PORT= {PORT}; DATABASE= {DATABASE};";
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();

            String query = "INSERT INTO employees(emp_first, emp_last, emp_class, emp_contact) VALUES(?firstname, ?lastname, ?class, ?contact)";

            MySqlCommand comm = new MySqlCommand(query,conn);
            comm.Parameters.AddWithValue("?firstname", firstName);
            comm.Parameters.AddWithValue("?lastname", lastName);
            comm.Parameters.AddWithValue("?class", designation);
            comm.Parameters.AddWithValue("?contact", contact);
            comm.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }

        public List<Employee> getAllEmployees()
        {
            List < Employee > employeeList = new List<Employee>();

            string connstring = $"SERVER= {SERVER}; USER ID= {USERID}; PASSWORD= {PASSWORD}; PORT= {PORT}; DATABASE= {DATABASE};";
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();

            String query = "SELECT emp_id, emp_first, emp_last, emp_class, emp_contact FROM employees";

            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                Employee employee = new Employee();
                employee.id = dr["emp_id"].ToString();
                employee.firstName = dr["emp_first"].ToString();
                employee.lastName = dr["emp_last"].ToString();
                employee.designation = dr["emp_class"].ToString();
                employee.contact = dr["emp_contact"].ToString();

                employeeList.Add(employee);
            }

            return employeeList;
        }

    }

}
