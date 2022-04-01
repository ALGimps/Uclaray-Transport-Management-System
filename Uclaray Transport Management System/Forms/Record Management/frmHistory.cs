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
        public frmHistory()
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
            var List = record.GetCompletedRecords();
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
                    record.Area,
                    record.Trip_number,
                    emp.getEmployee(record.Driver_id).fullName,
                    emp.getEmployee(record.Helper_id).fullName,
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
           
            if (dgvHistory.Rows[e.RowIndex].Cells[8].Value.ToString() == "Successful" && e.ColumnIndex == 8)
            {
                e.CellStyle.BackColor = Color.FromArgb(125, 207, 123);

            }
            if (dgvHistory.Rows[e.RowIndex].Cells[8].Value.ToString() == "Bad Order (Logistics)" && e.ColumnIndex == 8)
            {
                e.CellStyle.BackColor = Color.FromArgb(242, 78, 30);

            }
            if (dgvHistory.Rows[e.RowIndex].Cells[8].Value.ToString() == "Bad Order (Uclaray)" && e.ColumnIndex == 8)
            {
                e.CellStyle.BackColor = Color.FromArgb(242, 78, 30);

            }
            if (dgvHistory.Rows[e.RowIndex].Cells[8].Value.ToString() == "Cancelled" && e.ColumnIndex == 8)
            {
                e.CellStyle.BackColor = Color.DimGray;

            }

        }
    }
}
