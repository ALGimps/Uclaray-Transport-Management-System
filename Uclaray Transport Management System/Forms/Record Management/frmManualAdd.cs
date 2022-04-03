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
    public partial class frmManualAdd : Form
    {

        DeliveryRecord records = new DeliveryRecord();
        Trip trips = new Trip();
        private readonly frmAdvancedTrackingv2 parentForm;
        Logistics logistics = new Logistics();

        public frmManualAdd(frmAdvancedTrackingv2 frm)
        {
            InitializeComponent();
            parentForm = frm;
            BindingSource bindingSourceLogistics = new BindingSource
            {
                DataSource = logistics.GetLogistics()
            };
            cbologistics.DataSource = bindingSourceLogistics;
            cbologistics.DisplayMember = "name";
            cbologistics.ValueMember = "id";
        }


        private void frmManualAdd_Load(object sender, EventArgs e)
        {
            dtpDeliveryDate.MinDate = DateTime.Today;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbologistics.SelectedIndex < 0)
            {
                MessageBox.Show("Please select logistics");
                return;
            }
            if (txtTripAssignmentNo.Text.Length <= 0)
            {
                MessageBox.Show("Please enter Trip Assignment Number");
                return;
            }
            if (txtTruckType.Text.Length <= 0)
            {
                MessageBox.Show("Please enter the Truck type");
                return;
            }
            if (txtPlateNo.Text.Length <= 0)
            {
                MessageBox.Show("Please enter the plate number");
                return;
            }
            if (dgvDeliveries.Rows.Count <= 0)
            {
                MessageBox.Show("Please add a Delivery");
                return;
            }

            string date = dtpDeliveryDate.Value.ToString("yyyy-MM-dd");

            foreach (DataGridViewRow row in dgvDeliveries.Rows)
            {
               
                records.AddRecord(date, txtTripAssignmentNo.Text, int.Parse(cbologistics.SelectedValue.ToString()), row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), (int)row.Cells[3].Value, User.UserId);
            }
            trips.AddTrip(txtTripAssignmentNo.Text, date, txtTruckType.Text, txtPlateNo.Text, (int)nudNumberOfTrips.Value, (int)nudNumberOfDrops.Value);

            txtTripAssignmentNo.Clear();
            txtTruckType.Clear();
            txtPlateNo.Clear();
            nudNumberOfDrops.Value = 1;
            nudNumberOfTrips.Value = 1;
            cbologistics.SelectedIndex = -1;
            dtpDeliveryDate.ResetText();

            parentForm.LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddDeliveries_Click(object sender, EventArgs e)
        {
            
            if (txtCustomerName.Text.Length <= 0)
            {
                MessageBox.Show("Please enter Store name");
                return;
            }
            if (txtLocation.Text.Length <= 0)
            {
                MessageBox.Show("Please enter the Location");
                return;
            }
            if (txtArea.Text.Length <= 0)
            {
                MessageBox.Show("Please enter the Area");
                return;
            }

            dgvDeliveries.Rows.Add(txtCustomerName.Text, txtLocation.Text, txtArea.Text, (int)nudQuantity.Value, imageList1.Images[0]);
            txtCustomerName.Clear();
            txtLocation.Clear();
            txtArea.Clear();
            nudQuantity.Value = 1;

            dgvDeliveries.Rows.Clear();
            MessageBox.Show("Record Successfully Added");

        }

        private void dgvDeliveries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDeliveries.Columns[e.ColumnIndex].Index == 4)
            {
                dgvDeliveries.Rows.RemoveAt(dgvDeliveries.SelectedRows[0].Index);
            }
        }
    }
}
