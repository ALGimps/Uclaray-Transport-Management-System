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
        public int id { get; set; }
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


        //Define connection string

        static string SERVER = "localhost";
        static string USERID = "root";
        static string PASSWORD = "1234";
        static string PORT = "3306";
        static string DATABASE = "uclaray_product_tracking_management_system";

        //static string SERVER = "db4free.net";
        //static string USERID = "capstone_test";
        //static string PASSWORD = "capstone_test";
        //static string PORT = "3306";
        //static string DATABASE = "capstone_test";

        static string connstring = $"SERVER= {SERVER}; USER ID= {USERID}; PASSWORD= {PASSWORD}; PORT= {PORT}; DATABASE= {DATABASE};";

        //Checks if record already exist in database
        private bool recordExists(string firstName, string lastName, string contact)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();

            string query = "SELECT COUNT(emp_id) FROM employees WHERE emp_first=?firstname AND emp_last=?lastname AND emp_contact=?contact";

            //Initialize command
            MySqlCommand comm = new MySqlCommand(query, conn);
            comm.Parameters.AddWithValue("?firstname", firstName);
            comm.Parameters.AddWithValue("?lastname", lastName);
            comm.Parameters.AddWithValue("?contact", contact);

            //Execute
            int recordExist = Convert.ToInt32(comm.ExecuteScalar());
            conn.Close();
            conn.Dispose();

            if (recordExist > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Add new record to the employee table in database
        public void addEmployee(string firstName, string lastName, string designation, string contact)
        {
            //Check if record exist
            if (recordExists(firstName, lastName, contact))
            {
                System.Windows.Forms.MessageBox.Show("Record already exist", "Failed", System.Windows.Forms.MessageBoxButtons.OK);
                return;
            }

            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();

            string query = "INSERT INTO employees(emp_first, emp_last, emp_designation, emp_contact) VALUES(?firstname, ?lastname, ?designation, ?contact)";

            //Initialize Command
            MySqlCommand comm = new MySqlCommand(query, conn);
            comm.Parameters.AddWithValue("?firstname", firstName);
            comm.Parameters.AddWithValue("?lastname", lastName);
            comm.Parameters.AddWithValue("?designation", designation);
            comm.Parameters.AddWithValue("?contact", contact);

            //Execute
            comm.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }

        //Change employee status to active or inactive
        public void changeStatus(int id, int newStatus)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            string query = "UPDATE employees SET active = ?active WHERE emp_id = ?id";

            //Initialize command
            MySqlCommand comm = new MySqlCommand(query, conn);
            comm.Parameters.AddWithValue("?active", newStatus);
            comm.Parameters.AddWithValue("?id", id);

            //Execute
            comm.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }

        //Fetch all record in employees table
        public List<Employee> getAllEmployees()
        {
            List<Employee> employeeList = new List<Employee>();

            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();

            string query = "SELECT emp_id, emp_first, emp_last, emp_designation, emp_contact, active FROM employees ORDER by active DESC";

            //Initialize command
            MySqlCommand comm = new MySqlCommand(query, conn);

            //Execute Data reader
            MySqlDataReader dr = comm.ExecuteReader();

            //Populate List with data
            while (dr.Read())
            {
                Employee employee = new Employee();
                employee.id = (int)dr["emp_id"];
                employee.firstName = dr["emp_first"].ToString();
                employee.lastName = dr["emp_last"].ToString();
                employee.designation = dr["emp_designation"].ToString();
                employee.contact = dr["emp_contact"].ToString();
                employee.active = Convert.ToBoolean(dr["active"]);
                employeeList.Add(employee);
            }
            conn.Close();
            conn.Dispose();

            return employeeList;
        }

        public void updateEmployee(int id, string newFirst, string newLast, string newDesignation, string newContact)
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            string query = "UPDATE employees SET emp_first = ?newFirst, emp_last = ?newLast, emp_designation = ?newDesignation, emp_contact = ?newContact WHERE emp_id = ?id";

            //Initialize command
            MySqlCommand comm = new MySqlCommand(query, conn);
            comm.Parameters.AddWithValue("?id", id);
            comm.Parameters.AddWithValue("?newFirst", newFirst);
            comm.Parameters.AddWithValue("?newLast", newLast);
            comm.Parameters.AddWithValue("?newDesignation", newDesignation);
            comm.Parameters.AddWithValue("?newContact", newContact);

            //Execute
            comm.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }

        //FEtch single employee record on database
        public Employee getEmployee(int id)
        {
            Employee employee = new Employee();

            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();

            string query = "SELECT emp_id, emp_first, emp_last, emp_designation, emp_contact FROM employees WHERE emp_id = ?id LIMIT 0,1";

            //Initialize command
            MySqlCommand comm = new MySqlCommand(query, conn);
            comm.Parameters.AddWithValue("?id", id);

            //Execute Data reader
            MySqlDataReader dr = comm.ExecuteReader();

            //Populate List with data
            while (dr.Read())
            {
                employee.id = (int)dr["emp_id"];
                employee.firstName = dr["emp_first"].ToString();
                employee.lastName = dr["emp_last"].ToString();
                employee.designation = dr["emp_designation"].ToString();
                employee.contact = dr["emp_contact"].ToString();
            }

            return employee;
        }

        public List<Employee> searchEmployees(string searchText)
        {

            List<Employee> employeeList = new List<Employee>();

            // Initialize and open connection
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();

            string query = "SELECT emp_id, emp_first, emp_last, emp_designation, emp_contact, active FROM employees WHERE (emp_first LIKE ?searchText OR emp_last LIKE ?searchText) ORDER by active DESC";

            //Initialize command
            MySqlCommand comm = new MySqlCommand(query, conn);
            comm.Parameters.AddWithValue("?searchText", "%"+searchText+"%");

            //Execute Data reader
            MySqlDataReader dr = comm.ExecuteReader();

            //Populate List with data
            while (dr.Read())
            {
                Employee employee = new Employee();
                employee.id = (int)dr["emp_id"];
                employee.firstName = dr["emp_first"].ToString();
                employee.lastName = dr["emp_last"].ToString();
                employee.designation = dr["emp_designation"].ToString();
                employee.contact = dr["emp_contact"].ToString();
                employee.active = Convert.ToBoolean(dr["active"]);
                employeeList.Add(employee);
            }
            conn.Close();
            conn.Dispose();

            return employeeList;
        }

        public List<Employee> filterEmployees(string searchText, int filter)
        {
            string query = "SELECT emp_id, emp_first, emp_last, emp_designation, emp_contact, active FROM employees WHERE active = ?filter AND (emp_first LIKE %?searchText% OR emp_last LIKE %?searchText%)";
            if (searchText == "" )
            {
                query = "SELECT emp_id, emp_first, emp_last, emp_designation, emp_contact, active FROM employees WHERE active = ?filter";
            }
            if (true)
            {
                query = "SELECT emp_id, emp_first, emp_last, emp_designation, emp_contact, active FROM employees WHERE emp_first LIKE %?filter%";
            }

            List<Employee> employeeList = new List<Employee>();



            // Initialize and open connection
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();


            //Initialize command
            MySqlCommand comm = new MySqlCommand(query, conn);

            //Execute Data reader
            MySqlDataReader dr = comm.ExecuteReader();

            //Populate List with data
            while (dr.Read())
            {
                Employee employee = new Employee();
                employee.id = (int)dr["emp_id"];
                employee.firstName = dr["emp_first"].ToString();
                employee.lastName = dr["emp_last"].ToString();
                employee.designation = dr["emp_designation"].ToString();
                employee.contact = dr["emp_contact"].ToString();
                employee.active = Convert.ToBoolean(dr["active"]);
                employeeList.Add(employee);
            }
            conn.Close();
            conn.Dispose();

            return employeeList;
        }


    }

}
