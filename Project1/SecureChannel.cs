#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;

#endregion

namespace Project1
{
    public partial class SecureChannel : Form
    {
        public SecureChannel()
        {
            InitializeComponent();
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {

        }

        private void menuItem10_Click(object sender, EventArgs e)
        {
            VWGContext.Current.CurrentTheme = "Office2010";
        }

        private void menuItem9_Click(object sender, EventArgs e)
        {
            VWGContext.Current.CurrentTheme = "Vista";
        }

        private void SecureChannel_Load(object sender, EventArgs e)
        {
            VWGContext.Current.CurrentTheme = "Vista";
            this.splitContainer1.SelectedIndicator = false;
            this.splitContainer1.Panel1.SelectedIndicator = false;
        }

        private void splitContainer1_Panel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Click(object sender, EventArgs e)
        {

        }


    }
}