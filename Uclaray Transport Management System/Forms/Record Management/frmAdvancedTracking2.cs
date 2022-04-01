using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Uclaray_Transport_Management_System.Forms.Record_Management
{
    public partial class frmAdvancedTracking2 : Form
    {
        public frmAdvancedTracking2()
        {
            InitializeComponent();

            foreach (object obj in flPanelSide.Controls)
            {

                var panel = (Guna2Panel)obj;
                foreach (object obj1 in panel.Controls)
                {
                    if (obj1 is Guna2TileButton)
                    {
                        var b = (Guna2TileButton)obj1;
                        b.Click += guna2TileButton1_Click;
                    }
                }

            }

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("clicked");
        }


        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            ToggleVisibility((Guna2TileButton)sender);

        }


        private void ToggleVisibility(Guna2TileButton control)
        {

            foreach (object obj in flPanelSide.Controls)
            {

                var panel = (Guna2Panel)obj;
                panel.Size = new Size(200, 40);
                foreach (object obj1 in panel.Controls)
                {
                    if (obj1 is Guna2TileButton)
                    {
                        var b = (Guna2TileButton)obj1;
                        if (b != control)
                        {
                            b.Checked = false;
                        }
                    }
                }

            } 

            control.Parent.Size = control.Checked ? new Size(200, 140) : new Size(200, 40);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            guna2TileButton1.Checked = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
