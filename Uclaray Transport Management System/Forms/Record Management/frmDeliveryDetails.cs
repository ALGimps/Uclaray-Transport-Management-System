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
    public partial class frmDeliveryDetails : Form
    {
        private readonly frmCurrentDeliveries parentForm;
        DeliveryRecord record = new DeliveryRecord();
        Employee emp = new Employee();
        UserAccount user = new UserAccount();
        Status status = new Status();
        int ID;

        public frmDeliveryDetails(frmCurrentDeliveries frm, int RecordID)
        {
            InitializeComponent();
            ID = RecordID;
            parentForm = frm;
            LoadData(record.GetRecord(RecordID));
            BindingSource BindingSourceStatus = new BindingSource
            {
                DataSource = status.GetStatuses()
            };
            cbstatus.DataSource = BindingSourceStatus.DataSource;
            cbstatus.DisplayMember = "Name";
            cbstatus.ValueMember = "Id";
            cbstatus.SelectedIndex = -1;
        }

        void LoadData(DeliveryRecord _record)
        {
            lbltracking_id.Text = _record.id.ToString("D5");
            lblDeliveryDate.Text = _record.Delivery_date.ToString();
            lblPartnerCompany.Text = "Logistikus"; //_record.Logistics_id.ToString();
            lblStore.Text = _record.Store_name;
            lblLocation.Text = _record.Location;
            lblArea.Text = _record.Area;
            lblDriver.Text = emp.getEmployee(_record.Driver_id).fullName;
            lblHelper.Text = emp.getEmployee(_record.Helper_id).fullName;
            lblquantity.Text = _record.Quantity.ToString();
            lblTripAssignment.Text = _record.Trip_number;
            lblTruckType.Text = _record.Truck_type;
            lblPlateNo.Text = _record.Plate_no;
            lblDrops.Text = _record.Number_of_drop;
            lblTrips.Text = _record.Number_of_trips;
            lblAssign.Text = "Assigned by: " + user.GetUser(_record.User_id).fullName;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((int)cbstatus.SelectedValue == 2)
            {
                Close();
            }
            if (txtPONumber.Text==string.Empty)
            {
                MessageBox.Show("Please enter the PO number");
                txtPONumber.Focus();
                return;
            }

            if ((int)cbstatus.SelectedValue==3)
            {
                record.UpdateRecordStatus(ID,(int)cbstatus.SelectedValue,txtNote.Text);
                record.UpdatePONumber(ID, txtPONumber.Text);
                MessageBox.Show("Delivery record: " + ID.ToString("d5") + " is marked as " + cbstatus.SelectedText);
                parentForm.LoadData();
                Close();
            }
            else
            {
                if (txtNote.Text==string.Empty)
                {
                    MessageBox.Show("Please leave a note stating the reason");
                    txtNote.Focus();
                    return;
                }
                record.UpdateRecordStatus(ID, (int)cbstatus.SelectedValue, txtNote.Text);
                record.UpdatePONumber(ID, txtPONumber.Text);
                MessageBox.Show("Delivery record: " + ID.ToString("d5") + " is marked as " + cbstatus.SelectedText);
                parentForm.LoadData();
                Close();
            }
        }
    }

}

