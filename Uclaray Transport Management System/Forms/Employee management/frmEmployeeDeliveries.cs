using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uclaray_Transport_Management_System.Forms.Employee_management
{
    public partial class frmEmployeeDeliveries : Form
    {
        public frmEmployeeDeliveries(string name)
        {
            InitializeComponent();
            lblEmployeeName.Text = name.ToUpper();
            AutoScrollPosition = new Point(0, 0);
            ScrollControlIntoView(lblEmployeeName);
        }

        private void frmEmployeeDeliveries_Load(object sender, EventArgs e)
        {

        }
    }
}
