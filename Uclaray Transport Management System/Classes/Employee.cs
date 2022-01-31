using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Uclaray_Transport_Management_System.Classes
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

        public Employee(){

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

        //Checks if record already exist in database
        private bool recordExists(string firstName, string lastName, string contact)
        {

            string query = "SELECT COUNT(emp_id) FROM employees WHERE emp_first=?firstname AND emp_last=?lastname AND emp_contact=?contact";
            int records = 0 ;

            if (OpenConnection())
            {

                //Initialize command
                MySqlCommand comm = new MySqlCommand(query, connection);
                comm.Parameters.AddWithValue("?firstname", firstName);
                comm.Parameters.AddWithValue("?lastname", lastName);
                comm.Parameters.AddWithValue("?contact", contact);

                //Execute
                records = Convert.ToInt32(comm.ExecuteScalar());
                CloseConnection();
            }

            if (records > 0)
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

            string query = "INSERT INTO employees(emp_first, emp_last, emp_designation, emp_contact) VALUES(?firstname, ?lastname, ?designation, ?contact)";

            if (OpenConnection())
            {

                //Initialize Command
                MySqlCommand comm = new MySqlCommand(query, connection);
                comm.Parameters.AddWithValue("?firstname", firstName);
                comm.Parameters.AddWithValue("?lastname", lastName);
                comm.Parameters.AddWithValue("?designation", designation);
                comm.Parameters.AddWithValue("?contact", contact);

                //Execute
                comm.ExecuteNonQuery();
                MessageBox.Show("Sucessfully added", "Sucess", MessageBoxButtons.OK);
                CloseConnection();
            }
        }

        //Change employee status to active or inactive
        public void changeStatus(int id, int newStatus)
        {
            string query = "UPDATE employees SET active = ?active WHERE emp_id = ?id";

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

        //Fetch all record in employees table
        public List<Employee> getAllEmployees()
        {
            List<Employee> employeeList = new List<Employee>();

            string query = "SELECT emp_id, emp_first, emp_last, emp_designation, emp_contact, active FROM employees ORDER by active DESC";

            if (OpenConnection())
            {
                //Initialize command
                MySqlCommand comm = new MySqlCommand(query, connection);

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
                CloseConnection();

            }

            return employeeList;
        }

        public async Task<List<Employee>> getAllEmployee()
        {

            
            
            List<Employee> employeeList = new List<Employee>();

            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();

            string query = "SELECT emp_id, emp_first, emp_last, emp_designation, emp_contact, active FROM employees ORDER by active DESC";

            //Initialize command
            MySqlCommand comm = new MySqlCommand(query, conn);

            //Execute Data reader
            var dr = await comm.ExecuteReaderAsync();

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
            string query = "UPDATE employees SET emp_first = ?newFirst, emp_last = ?newLast, emp_designation = ?newDesignation, emp_contact = ?newContact WHERE emp_id = ?id";

            if (OpenConnection())
            {

                //Initialize command
                MySqlCommand comm = new MySqlCommand(query, connection);
                comm.Parameters.AddWithValue("?id", id);
                comm.Parameters.AddWithValue("?newFirst", newFirst);
                comm.Parameters.AddWithValue("?newLast", newLast);
                comm.Parameters.AddWithValue("?newDesignation", newDesignation);
                comm.Parameters.AddWithValue("?newContact", newContact);

                //Execute
                comm.ExecuteNonQuery();
                CloseConnection();
            }
        }

        //Fetch single employee record on database
        public Employee getEmployee(int id)
        {
            Employee employee = new Employee();

            string query = "SELECT emp_id, emp_first, emp_last, emp_designation, emp_contact FROM employees WHERE emp_id = ?id LIMIT 0,1";

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
                    employee.id = (int)dr["emp_id"];
                    employee.firstName = dr["emp_first"].ToString();
                    employee.lastName = dr["emp_last"].ToString();
                    employee.designation = dr["emp_designation"].ToString();
                    employee.contact = dr["emp_contact"].ToString();
                }
                CloseConnection();
            }
            return employee;
        }

        public List<Employee> searchEmployees(string searchText)
        {

            List<Employee> employeeList = new List<Employee>();

            string query = "SELECT emp_id, emp_first, emp_last, emp_designation, emp_contact, active FROM employees WHERE (emp_first LIKE ?searchText OR emp_last LIKE ?searchText) ORDER by active DESC";

            if (OpenConnection())
            {
                //Initialize command
                MySqlCommand comm = new MySqlCommand(query, connection);
                comm.Parameters.AddWithValue("?searchText", "%" + searchText + "%");

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
                CloseConnection();
            }

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
