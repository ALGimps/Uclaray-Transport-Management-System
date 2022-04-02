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

namespace Uclaray_Transport_Management_System.Forms
{
    public partial class frmDashboard : Form
    {

        static string connstring = connstring = DBUtils.connstring;
        private MySqlConnection connection = new MySqlConnection(connstring);

        public frmDashboard()
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy").ToString();
            fillChart();
        }
        private void fillChart()
        {
            DateTime dtStartMonth = DateTime.Now.AddMonths(-5);
            for (int i = 0; i < 6; i++)
            {
                var date = dtStartMonth.AddMonths(i);
                var monthName = date.ToString("MMMM yyyy");
                chart1.Series["Successful"].Points.AddXY(monthName,CountRecords(3,0, date.Month));
                chart1.Series["Pending"].Points.AddXY(monthName, CountRecords(2, 0, date.Month));
                chart1.Series["Bad"].Points.AddXY(monthName, CountRecords(4, 0, date.Month)+ CountRecords(5, 0, date.Month));

            }

            int badOrdersPerYear = CountRecords(4, DateTime.Now.Year) + CountRecords(4, DateTime.Now.Year);
            //AddXY value in chart1 in series named as Salary  
            lblPending.Text = CountRecords(2, DateTime.Now.Year).ToString();
            lblSuccessful.Text = CountRecords(3, DateTime.Now.Year).ToString();
            lblBad.Text = badOrdersPerYear.ToString();



            chart2.Series["Records"].Points.AddXY("", CountRecords(3,0,0,true));
            chart2.Series["Records"].Points.AddXY("", CountRecords(2, 0, 0, true));
            chart2.Series["Records"].Points.AddXY("", CountRecords(4, 0, 0, true) + CountRecords(5, 0, 0, true));


        }

        private int CountRecords(int Status, int Year=0, int Month=0, bool CurrentWeek = false)
        {
            int res=0;
            StringBuilder querysb = new StringBuilder("SELECT COUNT(tracking_id) FROM delivery_records WHERE status = ?Status ");

            if (Year != 0)
            {
                querysb.Append("AND YEAR(delivery_date) = ?Year ");
            }
            if (Month != 0)
            {
                querysb.Append("AND MONTH(delivery_date) = ?Month ");
            }
            if (CurrentWeek==true)
            {
                querysb.Append("AND YEARWEEK(delivery_Date,1) = YEARWEEK(CURDATE(),1)");
            }
            
            
            using (connection)
            {
                connection.Open();

                MySqlCommand comm = new MySqlCommand(querysb.ToString(), connection);
                comm.Parameters.AddWithValue("?Month", Month);
                comm.Parameters.AddWithValue("?Year", Year);
                comm.Parameters.AddWithValue("?Status", Status);
                //Execute Data reader
                MySqlDataReader dr = comm.ExecuteReader();

                //Populate List with data
                while (dr.Read())
                {
                    res = Convert.ToInt32(dr[0]);
                }
            }
            return res;
        }

    }
}
