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
    public partial class frmDeliveryDetailsSuccessful : Form
    {
        DeliveryRecord record = new DeliveryRecord();
        Employee emp = new Employee();
        UserAccount user = new UserAccount();
        Status myStatus = new Status();
        int ID;

        public frmDeliveryDetailsSuccessful(int RecordID)
        {
            InitializeComponent();
            ID = RecordID;
            LoadData(record.GetRecord(RecordID));
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
            lblPONumber.Text = _record.PO_number;
            lblNotes.Text = _record.Note;
            lblStatus.Text = myStatus.GetStatusName(_record.Status);
            switch (_record.Status)
            {
                case "2":
                    lblStatus.BackColor = Color.FromArgb(250, 184, 17);
                    break;
                case "3":
                    lblStatus.BackColor = Color.FromArgb(125, 207, 123);
                    break;
                case "4":
                    lblStatus.BackColor = Color.FromArgb(242, 78, 30);
                    break;
                case "5":
                    lblStatus.BackColor = Color.FromArgb(242, 78, 30);
                    break;
                case "6":
                    lblStatus.BackColor = Color.DimGray;
                    break;
                default:
                    break;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
