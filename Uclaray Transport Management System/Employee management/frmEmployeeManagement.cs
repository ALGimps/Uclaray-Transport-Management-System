using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uclaray_Transport_Management_System.Class;

namespace Uclaray_Transport_Management_System.Employee_management
{
    public partial class frmEmployeeManagement : Form
    {
        public frmEmployeeManagement()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            Employee employee = new Employee();
            List<Employee> employeeList = employee.getAllEmployees();
            dgvEmployees.DataSource = employeeList;
        }

        private void frmEmployeeManagement_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEmployee frm = new frmAddEmployee(this);
            frm.ShowDialog();
        }

    }
}
