﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class Isla_1 : Form
    {
        public Isla_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPC AdminPC = new AdminPC();
            AdminPC.ShowDialog();
            if (AdminPC.DialogResult == DialogResult.Yes)
            {

            }
        }
    }
}
