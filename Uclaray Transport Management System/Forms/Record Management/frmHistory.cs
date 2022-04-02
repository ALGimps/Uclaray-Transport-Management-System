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

namespace Uclaray_Transport_Management_System.Forms.Record_Management
{
    public partial class frmHistory : Form
    {
        DeliveryRecord record = new DeliveryRecord();
        int status = 0;
        public frmHistory()
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy").ToString();

            dtpEnd.Value = DateTime.Today;
            DateTime endDate = dtpEnd.Value;
            DateTime startDate = endDate.AddDays(-6);
            dtpStart.Value = startDate;

            LoadData();
        }

        public async void LoadData()
        {
            var recordList = await Task.Run(() => FetchData());
            PopulateDataGrid(recordList);
        }

        private List<DeliveryRecord> FetchData()
        {
            var List = record.GetCompletedRecords(dtpStart.Value, dtpEnd.Value, status, txtSearch.Text);
            return List;
        }

        private void PopulateDataGrid(List<DeliveryRecord> List)
        {

            dgvHistory.Rows.Clear();
            if (List.Count == 0)
            {
                lblLoading.Text = "Sorry, no records found";
                lblLoading.Visible = true;
                return;
            }
            lblLoading.Text = "Loading, please wait . . .";
            lblLoading.Visible = true;

            Employee emp = new Employee();

            foreach (var record in List)
            {
                int statusValue = Convert.ToInt32(record.Status);
                string statusName;

                switch (statusValue)
                {
                    case 3: statusName = "Successful";
                        break;
                    case 4:
                        statusName = "Bad Order (Logistics)";
                        break;
                    case 5:
                        statusName = "Bad Order (Uclaray)";
                        break;
                    case 6:
                        statusName = "Cancelled";
                        break;
                    default: statusName = "";
                        break;
                }

                var rowIndex = dgvHistory.Rows.Add(new object[]
                {
                    record.id,
                    record.Delivery_date.ToString("dd-MMM-yy"),
                    record.Store_name,
                    record.Location,
                    record.Quantity,
                    record.Trip_number,
                    emp.getEmployee(record.Driver_id).fullName,
                    emp.getEmployee(record.Helper_id).fullName,
                    record.PO_number,
                    statusName,
                    imageList1.Images[0]

                });
                dgvHistory.Rows[rowIndex].Cells[9].ToolTipText = "View Delivery Details";

            }
            lblLoading.Visible = false;
            lblRecords.Text = "Records: " + dgvHistory.RowCount.ToString();
        }

        private void dgvHistory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
            if (dgvHistory.Rows[e.RowIndex].Cells[9].Value.ToString() == "Successful" && e.ColumnIndex == 9)
            {
                e.CellStyle.BackColor = Color.FromArgb(125, 207, 123);
                e.CellStyle.SelectionBackColor = Color.FromArgb(125, 207, 123);

            }
            if (dgvHistory.Rows[e.RowIndex].Cells[9].Value.ToString() == "Bad Order (Logistics)" && e.ColumnIndex == 9)
            {
                e.CellStyle.BackColor = Color.FromArgb(242, 78, 30);
                e.CellStyle.SelectionBackColor = Color.FromArgb(242, 78, 30);

            }
            if (dgvHistory.Rows[e.RowIndex].Cells[9].Value.ToString() == "Bad Order (Uclaray)" && e.ColumnIndex == 9)
            {
                e.CellStyle.BackColor = Color.FromArgb(242, 78, 30);
                e.CellStyle.SelectionBackColor = Color.FromArgb(242, 78, 30);

            }
            if (dgvHistory.Rows[e.RowIndex].Cells[9].Value.ToString() == "Cancelled" && e.ColumnIndex == 9)
            {
                e.CellStyle.BackColor = Color.DimGray;
                e.CellStyle.SelectionBackColor = Color.DimGray;
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text=="")
            {
                LoadData();
            }
        }

        private void cbstatus_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cbstatus.SelectedIndex)
            { 
                case 1:
                    status = 3;
                    break;
                case 2:
                    status = 4;
                    break;
                case 3:
                    status = 5;
                    break;
                case 4:
                    status = 6;
                    break;
                default:
                    status = 0;
                    break;
            }
            LoadData();
        }
    }
}
