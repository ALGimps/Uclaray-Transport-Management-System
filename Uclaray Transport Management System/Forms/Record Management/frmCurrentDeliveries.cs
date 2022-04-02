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
    public partial class frmCurrentDeliveries : Form
    {
        DeliveryRecord record = new DeliveryRecord();
        public frmCurrentDeliveries()
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
            var List = record.GetAllRecords(2);
            return List;
        }

        private void PopulateDataGrid(List<DeliveryRecord> List)
        {

            dgvCurrentDeliveries.Rows.Clear();
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

                var rowIndex = dgvCurrentDeliveries.Rows.Add(new object[]
                {
                    record.id,
                    record.Delivery_date.ToString("dd-MMM-yy"),
                    record.Store_name,
                    record.Location,
                    record.Quantity,
                    record.Trip_number,
                    emp.getEmployee(record.Driver_id).fullName,
                    emp.getEmployee(record.Helper_id).fullName,
                    "Pending",
                    imageList1.Images[0]

                });
                dgvCurrentDeliveries.Rows[rowIndex].Cells[9].ToolTipText = "View Delivery Details";

            }
            lblLoading.Visible = false;
            lblRecords.Text = "Records: " + dgvCurrentDeliveries.RowCount.ToString();
        }

        private void dgvCurrentDeliveries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCurrentDeliveries.Columns[e.ColumnIndex].Index == dgvCurrentDeliveries.Columns.Count-1)
            {
                int id = (int)dgvCurrentDeliveries.SelectedCells[0].Value;
                frmDeliveryDetails frm = new frmDeliveryDetails(this,id);
                frm.ShowDialog();
            }
        }

        private void dgvCurrentDeliveries_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DateTime _deliveryDate = Convert.ToDateTime(dgvCurrentDeliveries.Rows[e.RowIndex].Cells[1].Value.ToString());
            int res = DateTime.Compare(_deliveryDate,DateTime.Today);
            if (res < 0 && e.ColumnIndex==1){
                
                e.CellStyle.ForeColor = Color.DarkRed;
                e.CellStyle.SelectionForeColor = Color.DarkRed;
            }
            if (e.ColumnIndex==8)
            {
                e.CellStyle.BackColor = Color.FromArgb(250, 184, 17);
            }
                
        }
    }
}
