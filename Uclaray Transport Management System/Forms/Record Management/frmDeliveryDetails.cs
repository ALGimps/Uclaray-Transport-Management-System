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


        public frmDeliveryDetails(frmCurrentDeliveries frm, int RecordID)
        {
            InitializeComponent();
            parentForm = frm;
            LoadData(record.GetRecord(RecordID));
        }


        void LoadData(DeliveryRecord _record)
        {
            lbltracking_id.Text = _record.id.ToString();
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

        }


    }
}
