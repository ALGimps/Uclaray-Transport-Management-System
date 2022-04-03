using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using MySql.Data.MySqlClient;
using Uclaray_Transport_Management_System.Classes;

namespace Uclaray_Transport_Management_System.Forms.Record_Management
{
    public partial class frmImportFromExcel : Form
    {

        string filePath = string.Empty;
        string fileExt = string.Empty;
        Logistics logistics = new Logistics();
        private readonly frmAdvancedTrackingv2 parentForm;

        public frmImportFromExcel(frmAdvancedTrackingv2 frm)
        {
            parentForm = frm;
            InitializeComponent();
            BindingSource bindingSourceLogistics = new BindingSource
            {
                DataSource = logistics.GetLogistics()
            };
            cbologistics.DataSource = bindingSourceLogistics;
            cbologistics.DisplayMember = "name";
            cbologistics.ValueMember = "id";

        }

        public DataTable ReadExcel(string fileName, string query)
        {
            string conn = string.Empty;
            DataTable dtexcel = new DataTable();

            conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties='Excel 12.0;HDR=YES';"; //for above excel 2007  
            using (OleDbConnection con = new OleDbConnection(conn))
            {
                //string query = "Select [delivery date], [customer name], [location], [area], [trip assignment number], [truck type], [plate no], [no of drop], [trips], [quantity] from [Sheet1$]";
               
                OleDbDataAdapter oleAdpt = new OleDbDataAdapter(query, con); //here we read data from sheet1  
                oleAdpt.Fill(dtexcel); //fill excel data into dataTable  

            }
            return dtexcel;

        }


        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog(); //open dialog to choose file  
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK) //if there is a file choosen by the user  
            {
                filePath = file.FileName; //get the path of the file  
                fileExt = Path.GetExtension(filePath); //get the file extension  
                if (fileExt.CompareTo(".xls") == 0 || fileExt.CompareTo(".xlsx") == 0)
                {
                    try
                    {
                        DataTable dtExcel = new DataTable();
                        dtExcel = ReadExcel(filePath, "Select DISTINCT[delivery date], [customer name], [location], [area], [trip assignment number], [truck type], [plate no], [no of drop], [trips], [quantity] from[Sheet1$]"); //read excel file  
                        dgvDeliveries.Visible = true;
                        dgvDeliveries.DataSource = dtExcel;
                        btnImport.Visible = false;
                        lblDrop.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        filePath = string.Empty;
                    }

                }
                else
                {
                    MessageBox.Show("Please choose .xls or .xlsx file only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error); //custom messageBox to show error  
                    filePath = string.Empty;
                }
            }
        }

        private void dgvDeliveries_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void dgvDeliveries_DragDrop(object sender, DragEventArgs e)
        {

            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[]; // get all files droppeds  
            if (files != null && files.Any())

                filePath = files.First(); //get the path of the file  
            fileExt = Path.GetExtension(filePath); //get the file extension  
            if (fileExt.CompareTo(".xls") == 0 || fileExt.CompareTo(".xlsx") == 0)
            {
                try
                {
                    DataTable dtExcel = new DataTable();
                    dtExcel = ReadExcel(filePath, "Select DISTINCT[delivery date], [customer name], [location], [area], [trip assignment number], [truck type], [plate no], [no of drop], [trips], [quantity] from[Sheet1$]"); //read excel file  
                    
                    dgvDeliveries.DataSource = dtExcel;
                    btnImport.Visible = false;
                    lblDrop.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    filePath = string.Empty;
                }

            }
            else
            {
                MessageBox.Show("Please choose .xls or .xlsx file only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error); //custom messageBox to show error  
                filePath = string.Empty;
            }

        }

        private void dgvDeliveries_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("hi");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnImport.Visible = true;
            lblDrop.Visible = true;
            dgvDeliveries.DataSource = null;
            filePath = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (filePath == string.Empty)
            {
                MessageBox.Show("Please Select a File");
                return;
            }

            SaveData();



        }

        private async void SaveData()
        {
            DataTable _dtTrips = new DataTable();
            DataTable _dtDeliveriess = new DataTable();

            Trip trip = new Trip();
            DeliveryRecord record = new DeliveryRecord();

            _dtTrips = ReadExcel(filePath, "Select DISTINCT [trip assignment number], [delivery date], [truck type], [plate no], [no of drop], [trips] from[Sheet1$]");
            _dtDeliveriess = ReadExcel(filePath, "Select DISTINCT [delivery date], [trip assignment number], [customer name], [location], [area], [Quantity] from[Sheet1$]");

            foreach (DataRow row in _dtTrips.Rows)
            {
                Trip _trip = new Trip();
                DateTime date = Convert.ToDateTime(row[1].ToString());
                await Task.Run(() => _trip.AddTrip(row[0].ToString(), date.ToString("yyyy-MM-dd"), row[2].ToString(), row[3].ToString(), int.Parse(row[4].ToString()), int.Parse(row[5].ToString())));
            }

            foreach (DataRow row in _dtDeliveriess.Rows)
            {
                DeliveryRecord _record = new DeliveryRecord();
                DateTime date = Convert.ToDateTime(row[0].ToString());
                int logisticsId = int.Parse(cbologistics.SelectedValue.ToString());
                await Task.Run(() => _record.AddRecord(date.ToString("yyyy-MM-dd"), row[1].ToString(), logisticsId, row[2].ToString(), row[3].ToString(), row[4].ToString(), int.Parse(row[5].ToString()), User.UserId));
            }

            MessageBox.Show("Successfully Added");
            parentForm.LoadData();

        }


    }
}
