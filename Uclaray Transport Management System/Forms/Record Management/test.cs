﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uclaray_Transport_Management_System.Record_Management
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void test_Leave(object sender, EventArgs e)
        {
            Close();
        }
    }
}