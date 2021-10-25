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
        [System.ComponentModel.DisplayName("ID")]
        public string id { get; set; }
        [System.ComponentModel.DisplayName("First name")]
        public string firstName { get; set; }
        [System.ComponentModel.DisplayName("Last name")]
        public string lastName { get; set; }
        [System.ComponentModel.DisplayName("Designation")]
        public string designation { get; set; }
        [System.ComponentModel.DisplayName("Contact")]
        public string contact { get; set; }
        [System.ComponentModel.DisplayName("Active")]
        public bool active { get; set; }



        static string SERVER = "localhost";
        static string USERID = "root";
        static string PASSWORD = "1234";
        static string PORT = "3306";
        static string DATABASE = "uclaray_product_tracking_management_system";
        static string connstring = $"SERVER= {SERVER}; USER ID= {USERID}; PASSWORD= {PASSWORD}; PORT= {PORT}; DATABASE= {DATABASE};";

        private bool RecordExists(string firstName, string lastName, string contact)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();

            string query = "SELECT COUNT(emp_id) FROM employees WHERE emp_first=?firstname AND emp_last=?lastname AND emp_contact=?contact";

            MySqlCommand comm = new MySqlCommand(query, conn);
            comm.Parameters.AddWithValue("?firstname", firstName);
            comm.Parameters.AddWithValue("?lastname", lastName);
            comm.Parameters.AddWithValue("?contact", contact);
            int recordExist = Convert.ToInt32(comm.ExecuteScalar());
            conn.Close();
            conn.Dispose();

            if (recordExist>0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void AddEmployee(string firstName, string lastName, string designation, string contact)
        {

            if (RecordExists(firstName,lastName,contact))
            {
                System.Windows.Forms.MessageBox.Show("Record already exist", "Failed", System.Windows.Forms.MessageBoxButtons.OK);
                return;
            }

            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();

            string query = "INSERT INTO employees(emp_first, emp_last, emp_class, emp_contact) VALUES(?firstname, ?lastname, ?class, ?contact)";

            MySqlCommand comm = new MySqlCommand(query,conn);
            comm.Parameters.AddWithValue("?firstname", firstName);
            comm.Parameters.AddWithValue("?lastname", lastName);
            comm.Parameters.AddWithValue("?class", designation);
            comm.Parameters.AddWithValue("?contact", contact);
            comm.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
            System.Windows.Forms.MessageBox.Show("Sucessfully added", "Sucess", System.Windows.Forms.MessageBoxButtons.OK);
        }

        public void ChangeStatus(int id, int isActive)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            string query = "UPDATE employees SET active = ?active WHERE emp_id = ?id";
            MySqlCommand comm = new MySqlCommand(query, conn);
            comm.Parameters.AddWithValue("?active", isActive);
            comm.Parameters.AddWithValue("?id", id);
            comm.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }

        public List<Employee> getAllEmployees()
        {
            List < Employee > employeeList = new List<Employee>();

            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();

            string query = "SELECT emp_id, emp_first, emp_last, emp_class, emp_contact, active FROM employees";

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
                //Boolean.TryParse(dr["active"].ToString(), out bool result);
                employee.active = Convert.ToBoolean(dr["active"]);
                //employee.active = true;
                employeeList.Add(employee);
            }

            return employeeList;
        }

    }

}
