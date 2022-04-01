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
    public partial class frmAdvancedTrackingv2 : Form
    {
        DeliveryRecord record = new DeliveryRecord();
        Trip trips = new Trip();
        static Employee emp = new Employee();
        BindingSource BindingSourceDriver = new BindingSource
        {
            DataSource = emp.getAllEmployees("WHERE emp_designation = 'Driver' AND active = 1")
        };
        BindingSource BindingSourceHelper = new BindingSource
        {
            DataSource = emp.getAllEmployees("WHERE emp_designation = 'Helper' AND active = 1")
        };


        public frmAdvancedTrackingv2()
        {
            InitializeComponent();
            LoadData();
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy").ToString();
        }

        public async void LoadData()
        {
            var recordList = await Task.Run(() => FetchData());
            PopulateDataGrid(recordList, dgvAdvancedTracking);
            dgvAdvancedTracking.CellContentClick += dgvAdvancedTracking_CellContentClick;
        }

        private List<Trip> FetchData()
        {
            var List = trips.GetAllTrips();
            return List;
        }

        private void PopulateDataGrid(List<Trip> List, DataGridView dgv)
        {

            dgv.Rows.Clear();
            if (List.Count == 0)
            {
                lblLoading.Text = "Sorry, no records found";
                lblLoading.Visible = true;
                return;
            }
            lblLoading.Text = "Loading, please wait . . .";
            lblLoading.Visible = true;


            using (DataGridViewComboBoxColumn col = (DataGridViewComboBoxColumn)dgv.Columns[7])
            {
                col.DataSource = BindingSourceDriver.DataSource;
                col.DisplayMember = "fullName";
                col.ValueMember = "id";

            }

            using (DataGridViewComboBoxColumn col = (DataGridViewComboBoxColumn)dgv.Columns[8])
            {
                col.DataSource = BindingSourceHelper.DataSource;
                col.DisplayMember = "fullName";
                col.ValueMember = "id";
            }

            foreach (var record in List)
            {
                var rowIndex = dgv.Rows.Add(new object[]
                {
                    record.Trip_number,
                    record.Trip_date.ToString("dd-MMM-yy"),
                    record.Trip_number,
                    record.Truck_type,
                    record.Plate_no,
                    record.Number_of_drop,
                    record.Number_of_trips

                });

                dgv.Rows[rowIndex].Cells[9].Value = imageList1.Images[0];

            }
            lblLoading.Visible = false;
        }

        private void PopulateDeliveryTable(List<DeliveryRecord> List, DataGridView dgv)
        {

            dgv.Rows.Clear();

            foreach (var record in List)
            {
                dgv.Rows.Add(new object[]
                {
                    record.id,
                    record.Store_name,
                    record.Location,
                    record.Area,
                    record.Quantity

                });
            }

            lblLoading.Visible = false;
            lblDeliveryCount.Text = "("+dgvDeliveries.Rows.Count.ToString()+")";

        }
        public async void LoadDeliveries(string tripID)
        {
            var recordList = await Task.Run(() => record.GetRecordsOfTrip(tripID));
            PopulateDeliveryTable(recordList, dgvDeliveries);
        }

        private void dgvAdvancedTracking_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAdvancedTracking.SelectedRows.Count > 0)
            {
                string selectedTripID = dgvAdvancedTracking.SelectedCells[2].Value.ToString();
               
                LoadDeliveries(selectedTripID);
            }

        }

        private string MessageBuilder(string DriverName, string HelperName, DateTime DeliveryDate)
        {
            StringBuilder message = new StringBuilder();
            message.Append("Good Day! @Driver and @Helper");
            message.AppendLine();
            message.AppendLine("Ito and schedule niyo para sa @Date");

            message.Replace("@Driver", DriverName);
            message.Replace("@Helper", HelperName);
            message.Replace("@Date", DeliveryDate.ToString("MMMM dd, yyyy - dddd"));

            foreach (DataGridViewRow row in dgvDeliveries.Rows)
            {
                int _deliveryNum = 0;
                _deliveryNum++;

                string storeName = row.Cells[1].Value.ToString();
                string location = row.Cells[2].Value.ToString();
                string area = row.Cells[3].Value.ToString();
                string quantity = row.Cells[4].Value.ToString();

                message.Append(_deliveryNum.ToString());
                message.Append("\nStore Name: " + storeName);
                message.Append("\nLocation: " + location);
                message.Append("\nArea: " + area);
                message.Append("\nQuantity: " + quantity);
                message.AppendLine();


            }
            message.AppendLine("END");

            return message.ToString();

        }

        private void dgvAdvancedTracking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAdvancedTracking.Columns[e.ColumnIndex].Index == 9)
            {

                if (dgvAdvancedTracking.SelectedCells[7].Value == null)
                {
                    MessageBox.Show("Please select a Driver");
                    return;
                }

                if (dgvAdvancedTracking.SelectedCells[8].Value == null)
                {
                    MessageBox.Show("Please select a Helper");
                    return;
                }

                string tripNo = dgvAdvancedTracking.SelectedCells[0].Value.ToString();
                int driverID = (int)dgvAdvancedTracking.SelectedCells[7].Value;
                int helperId = (int)dgvAdvancedTracking.SelectedCells[8].Value;

                trips.AssignDriverHelper(tripNo, driverID, helperId);
                LoadData();

                //Build Message to send via SMS
                Employee emp = new Employee();
                string driverName = emp.getEmployee(driverID).fullName;
                string helperName = emp.getEmployee(helperId).fullName;
                DateTime DeliveryDate = Convert.ToDateTime(dgvAdvancedTracking.SelectedCells[1].Value.ToString());
                string message = MessageBuilder(driverName, helperName, DeliveryDate);

                //Get contact and send sms
                string helperNumber = emp.getEmployee(helperId).contact;
                string driverNumber = emp.getEmployee(driverID).contact;

                //SMS.Send(driverNumber,message);
                //SMS.Send(helperNumber, message);


            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmManualAdd frm = new frmManualAdd(this);
            
            frm.ShowDialog();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            frmImportFromExcel frm = new frmImportFromExcel(this);
            frm.ShowDialog();
        }
    }
}
