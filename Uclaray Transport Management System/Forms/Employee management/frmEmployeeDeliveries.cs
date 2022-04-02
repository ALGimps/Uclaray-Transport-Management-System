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

namespace Uclaray_Transport_Management_System.Forms.Employee_management
{
    public partial class frmEmployeeDeliveries : Form
    {

        DeliveryRecord record = new DeliveryRecord();
        int employeeID;
        public frmEmployeeDeliveries(string name, int empID)
        {
            employeeID = empID;
            InitializeComponent();
            lblEmployeeName.Text = name.ToUpper();
            AutoScrollPosition = new Point(0, 0);
            ScrollControlIntoView(lblEmployeeName);
            LoadData();
        }

        private void frmEmployeeDeliveries_Load(object sender, EventArgs e)
        {

        }

        public async void LoadData()
        {
            var recordList = await Task.Run(() => FetchData());
            PopulateDataGrid(recordList);
        }

        private List<DeliveryRecord> FetchData()
        {
            var List = record.LoadEmployeeDeliveries(employeeID);
            return List;
        }

        private void PopulateDataGrid(List<DeliveryRecord> List)
        {

            dgvEmployeeDeliveries.Rows.Clear();
            if (List.Count == 0)
            {
                lblLoading.Text = "Sorry, no records found";
                lblLoading.Visible = true;
                return;
            }
            lblLoading.Text = "Loading, please wait . . .";
            lblLoading.Visible = true;

            Employee emp = new Employee();
            Status status = new Status();
            foreach (var record in List)
            {

                var rowIndex = dgvEmployeeDeliveries.Rows.Add(new object[]
                {
                    record.id,
                    record.Delivery_date.ToString("dd-MMM-yy"),
                    record.Store_name,
                    record.Quantity,
                    emp.getEmployee(record.Driver_id).fullName,
                    emp.getEmployee(record.Helper_id).fullName,
                    record.PO_number,
                    record.StatusName,
                    imageList1.Images[0]

                });
                dgvEmployeeDeliveries.Rows[rowIndex].Cells[8].ToolTipText = "View Delivery Details";

            }
            lblLoading.Visible = false;
        }

        private void dgvEmployeeDeliveries_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvEmployeeDeliveries.Rows[e.RowIndex].Cells[7].Value.ToString() == "Pending" && e.ColumnIndex == 7)
            {
                e.CellStyle.BackColor = Color.FromArgb(250, 184, 17);
                e.CellStyle.SelectionBackColor = Color.FromArgb(250, 184, 17);

            }
            if (dgvEmployeeDeliveries.Rows[e.RowIndex].Cells[7].Value.ToString() == "Successful" && e.ColumnIndex == 7)
            {
                e.CellStyle.BackColor = Color.FromArgb(125, 207, 123);
                e.CellStyle.SelectionBackColor = Color.FromArgb(125, 207, 123);

            }
            if (dgvEmployeeDeliveries.Rows[e.RowIndex].Cells[7].Value.ToString() == "Bad Order (Logistics)" && e.ColumnIndex == 7)
            {
                e.CellStyle.BackColor = Color.FromArgb(242, 78, 30);
                e.CellStyle.SelectionBackColor = Color.FromArgb(242, 78, 30);

            }
            if (dgvEmployeeDeliveries.Rows[e.RowIndex].Cells[7].Value.ToString() == "Bad Order (Uclaray)" && e.ColumnIndex == 7)
            {
                e.CellStyle.BackColor = Color.FromArgb(242, 78, 30);
                e.CellStyle.SelectionBackColor = Color.FromArgb(242, 78, 30);

            }
            if (dgvEmployeeDeliveries.Rows[e.RowIndex].Cells[7].Value.ToString() == "Cancelled" && e.ColumnIndex == 7)
            {
                e.CellStyle.BackColor = Color.DimGray;
                e.CellStyle.SelectionBackColor = Color.DimGray;
            }
        }
    }
}
