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
        Employee employee = new Employee();
        public frmEmployeeManagement()
        {
            InitializeComponent();
            loadData();
            lblRecords.Text = "Records: " + dgvEmployees.RowCount.ToString();
        }

        public void loadData()
        {
            List<Employee> employeeList = employee.getAllEmployees();
            //dgvEmployees.DataSource = employeeList;
            dgvEmployees.Rows.Clear();
            foreach(var emp in employeeList)
            {
                var rowIndex = dgvEmployees.Rows.Add(new object[]
                {
                    emp.id,
                    emp.firstName,
                    emp.lastName,
                    emp.designation,
                    emp.active ? imageList1.Images[0] : imageList1.Images[1] ,
                    emp.contact,
                    imageList1.Images[2],
                    emp.active ? imageList1.Images[3] : imageList1.Images[4]
                }) ;
                dgvEmployees.Rows[rowIndex].Cells[4].Tag = emp.active;
                dgvEmployees.Rows[rowIndex].Cells[6].ToolTipText = "Update employee details";
                var tooltip = emp.active ? "Set employee as inactive" : "Set employee as active";
                dgvEmployees.Rows[rowIndex].Cells[7].ToolTipText = tooltip;
            }
        }

        private void frmEmployeeManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEmployee frm = new frmAddEmployee(this);
            frm.ShowDialog();
        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmployees.Columns[e.ColumnIndex].Name == "update")
            {
                var columnID = dgvEmployees.SelectedCells[0].Value;
                if (MessageBox.Show("Update " + columnID, "Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    MessageBox.Show("updated " + columnID);
                }
            }
            if (dgvEmployees.Columns[e.ColumnIndex].Name == "setInactive")
            {
                var columnID = dgvEmployees.SelectedCells[0].Value;
                 if (Convert.ToBoolean(dgvEmployees.SelectedCells[4].Tag)){
                    if (MessageBox.Show("Do you want to set the status of employee no. " + columnID + " to inactive?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        employee.ChangeStatus(Convert.ToInt32(columnID),0);
                    }
                }
                else
                {
                    if (MessageBox.Show("Do you want to set the status of employee no. " + columnID + " to active?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        employee.ChangeStatus(Convert.ToInt32(columnID),1);
                    }
                }

                loadData();
            }

        }
    }
}
