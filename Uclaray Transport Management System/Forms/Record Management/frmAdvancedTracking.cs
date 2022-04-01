using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Uclaray_Transport_Management_System.Classes;

namespace Uclaray_Transport_Management_System.Forms.Record_Management
{
    public partial class frmAdvancedTracking : Form
    {
        DeliveryRecord record = new DeliveryRecord();
        //readonly static string connstring = DBUtils.connstring;
        //MySqlConnection connection = new MySqlConnection(connstring);
        Employee emp = new Employee();
        BindingSource BindingSourceDriver = new BindingSource();
        BindingSource BindingSourceHelper = new BindingSource();

        public frmAdvancedTracking()
        {
            InitializeComponent();
            LoadData();
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy").ToString();
            BindingSourceDriver.DataSource = emp.getAllEmployees("WHERE emp_designation = 'Driver' AND active = 1");
            BindingSourceHelper.DataSource = emp.getAllEmployees("WHERE emp_designation = 'Helper' AND active = 1");
            cboDriver.DataSource = BindingSourceDriver.DataSource;
            cboDriver.DisplayMember = "fullName";
            cboDriver.ValueMember = "id";
            cboDriver.StartIndex = -1;

            cboHelper.DataSource = BindingSourceHelper.DataSource;
            cboHelper.DisplayMember = "fullName";
            cboHelper.ValueMember = "id";
            cboHelper.StartIndex = -1;
        }

        private void frmAdvancedTracking_Load(object sender, EventArgs e)
        {


        }

        public async void LoadData()
        {
            var recordList = await Task.Run(() => FetchData());
            PopulateDataGrid(recordList);
        }

        private List<DeliveryRecord> FetchData()
        {
            var List = record.GetAllRecords(1);
            return List;
        }

        private void PopulateDataGrid(List<DeliveryRecord> List)
        {

            dgvAdvancedTracking.Rows.Clear();
            if (List.Count == 0)
            {
                lblLoading.Text = "Sorry, no records found";
                lblLoading.Visible = true;
                return;
            }
            lblLoading.Text = "Loading, please wait . . .";
            lblLoading.Visible = true;
            foreach (var record in List)
            {
                var rowIndex = dgvAdvancedTracking.Rows.Add(new object[]
                {
                    record.id,
                    record.Delivery_date.ToString("dd-MMM-yy"),
                    record.Store_name,
                    record.Location,
                    record.Area,
                    record.Trip_number,
                    record.Truck_type,
                    record.Plate_no,
                    record.Number_of_drop,
                    record.Number_of_trips

                });
                //record.active ? imageList1.Images[0] : imageList1.Images[1] ,
                //record.contact,
                //imageList1.Images[2],
                //record.active ? imageList1.Images[3] : imageList1.Images[4],
                //imageList2.Images[0]

                //dgvEmployees.Rows[rowIndex].Cells[4].Tag = emp.active;
                //dgvEmployees.Rows[rowIndex].Cells[6].ToolTipText = "Update employee information";
                //var tooltip = emp.active ? "Set employee as inactive" : "Set employee as active";
                //dgvEmployees.Rows[rowIndex].Cells[7].ToolTipText = tooltip;

                dgvAdvancedTracking.Rows[rowIndex].Cells[12].Value = imageList1.Images[0];


                using (DataGridViewComboBoxColumn col = (DataGridViewComboBoxColumn)dgvAdvancedTracking.Columns[10])
                {
                    col.DataSource = BindingSourceDriver.DataSource;
                    col.DisplayMember = "fullName";
                    col.ValueMember = "id";

                }

                using (DataGridViewComboBoxColumn col = (DataGridViewComboBoxColumn)dgvAdvancedTracking.Columns[11])
                {
                    col.DataSource = BindingSourceHelper.DataSource;
                    col.DisplayMember = "fullName";
                    col.ValueMember = "id";
                }

            }
            lblLoading.Visible = false;
            lblRecords.Text = "Records: " + dgvAdvancedTracking.RowCount.ToString();
        }

        private void dgvAdvancedTracking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAdvancedTracking.Columns[e.ColumnIndex].Index == 12)
            {

                if(dgvAdvancedTracking.SelectedCells[10].Value == null)
                {
                    MessageBox.Show("Please select a Driver");
                    return;
                }

                if (dgvAdvancedTracking.SelectedCells[11].Value == null)
                {
                    MessageBox.Show("Please select a Helper");
                    return;
                }

                int recordID = (int)dgvAdvancedTracking.SelectedCells[0].Value;
                int driverID = (int)dgvAdvancedTracking.SelectedCells[10].Value;
                int helperId = (int)dgvAdvancedTracking.SelectedCells[11].Value;

                //record.AssignDriverHelper(recordID,driverID,helperId);
                LoadData();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {



            //var selectedRows = dgvAdvancedTracking.SelectedRows
            //.OfType<DataGridViewRow>()
            //.Where(row => !row.IsNewRow)
            //.ToArray();

            //foreach (var row in selectedRows)

            //    row.Cells[10].Value = "ha";
                //row.Cells[11].Value = "ha";

                //dgvAdvancedTracking.Rows.Remove(row);

                //dgvAdvancedTracking.ClearSelection();
        }


        private void cboDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvAdvancedTracking.SelectedRows)
            {
                row.Cells[10].Value = cboDriver.SelectedValue;
            }
        }

        private void cboHelper_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvAdvancedTracking.SelectedRows)
            {
                row.Cells[11].Value = cboHelper.SelectedValue;
            }
        }

        private void dgvAdvancedTracking_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAdvancedTracking.SelectedRows.Count > 1)
            {
                panelBatchAssign.BringToFront();
                panelBatchAssign.Visible = true;

            }
            else
            {
                panelBatchAssign.Visible = false;
            }
        }
    }
}

