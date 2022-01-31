using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uclaray_Transport_Management_System.Forms.Logistics_partner_management
{
    public partial class frmPartnerCompanies : Form
    {
        public frmPartnerCompanies()
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy").ToString();
        }
    }
}
