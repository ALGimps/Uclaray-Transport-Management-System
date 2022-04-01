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
            LoadData();
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy").ToString();
        }

        public async void LoadData()
        {
            var recordList = await Task.Run(() => FetchData());
            PopulateDataGrid(recordList);
        }

        private List<DeliveryRecord> FetchData()
        {
            var List = record.GetAllRecords(3);
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
                    record.Area,
                    record.Trip_number,
                    emp.getEmployee(record.Driver_id).fullName,
                    emp.getEmployee(record.Helper_id).fullName,
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
            if (e.ColumnIndex == 8)
            {
                e.CellStyle.BackColor = Color.FromArgb(125, 207, 123);
            }
        }
    }
}
