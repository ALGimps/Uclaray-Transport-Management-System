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
    public partial class frmSuccessfulDeliveries : Form
    {
        DeliveryRecord record = new DeliveryRecord();
        public frmSuccessfulDeliveries()
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
            var List = record.GetSuccessfulRecords(dtpStart.Value,dtpEnd.Value,txtSearch.Text);
            return List;
        }

        private void PopulateDataGrid(List<DeliveryRecord> List)
        {

            dgvSuccessfulDeliveries.Rows.Clear();
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

                var rowIndex = dgvSuccessfulDeliveries.Rows.Add(new object[]
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
                    "Successful",
                    imageList1.Images[0]

                });
                dgvSuccessfulDeliveries.Rows[rowIndex].Cells[9].ToolTipText = "View Delivery Details";

            }
            lblLoading.Visible = false;
            lblRecords.Text = "Records: " + dgvSuccessfulDeliveries.RowCount.ToString();
        }

        private void dgvSuccessfulDeliveries_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                e.CellStyle.BackColor = Color.FromArgb(125, 207, 123);
            }
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
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
    }
}
