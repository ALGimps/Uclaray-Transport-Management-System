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

        private void dgvAdvancedTracking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
