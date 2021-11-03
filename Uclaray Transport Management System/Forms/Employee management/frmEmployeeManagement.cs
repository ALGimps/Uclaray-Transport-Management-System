using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uclaray_Transport_Management_System.Classes;

namespace Uclaray_Transport_Management_System.Employee_management
{
    public partial class frmEmployeeManagement : Form
    {
        Employee employee = new Employee();
        public frmEmployeeManagement()
        {
            InitializeComponent();
            LoadData();
        }

        public async void LoadData()
        {
            var employeeList = await Task.Run(() => FetchData());
            PopulateDataGrid(employeeList);
        }

        private List<Employee> FetchData()
        {
            var empList = employee.getAllEmployees();
            return empList;
        }

        private void PopulateDataGrid(List<Employee> employeeList)
        {
            dgvEmployees.Rows.Clear();
            if (employeeList.Count == 0)
            {
                lblLoading.Text = "Sorry, no records found";
                lblLoading.Visible = true;
                return;
            }
            lblLoading.Text = "Loading, please wait . . .";
            lblLoading.Visible = true;
            foreach (var emp in employeeList)
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
                });
                dgvEmployees.Rows[rowIndex].Cells[4].Tag = emp.active;
                dgvEmployees.Rows[rowIndex].Cells[6].ToolTipText = "Update employee details";
                var tooltip = emp.active ? "Set employee as inactive" : "Set employee as active";
                dgvEmployees.Rows[rowIndex].Cells[7].ToolTipText = tooltip;
            }
            lblLoading.Visible = false;
            lblRecords.Text = "Records: " + dgvEmployees.RowCount.ToString();
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
                frmUpdateEmployee frm = new frmUpdateEmployee(this, (int)columnID);
                frm.ShowDialog();
            }
            if (dgvEmployees.Columns[e.ColumnIndex].Name == "setInactive")
            {
                var name = dgvEmployees.SelectedCells[1].Value.ToString() + " " + dgvEmployees.SelectedCells[2].Value.ToString();
                var columnID = dgvEmployees.SelectedCells[0].Value;
                 if (Convert.ToBoolean(dgvEmployees.SelectedCells[4].Tag)){
                    if (MessageBox.Show("Do you want to set the status of " + name + " to inactive?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        employee.changeStatus(Convert.ToInt32(columnID),0);
                    }
                }
                else
                {
                    if (MessageBox.Show("Do you want to set the status of " + name + " to active?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        employee.changeStatus(Convert.ToInt32(columnID),1);
                    }
                }

                LoadData();
            }


        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearch.Text))
            {
                LoadData();
            }
            else
            {
                dgvEmployees.Rows.Clear();
                lblLoading.Text = "Searching, please wait . . .";
                lblLoading.Visible = true;
                var employeeList = await Task.Run(() => fetchSearchedData(txtSearch.Text.Trim()));
                PopulateDataGrid(employeeList);
            }
        }

        private List<Employee> fetchSearchedData(string SearchText)
        {
            var empList = employee.searchEmployees(SearchText);
            return empList;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvEmployees.Rows.Clear();
        }

    }
}
