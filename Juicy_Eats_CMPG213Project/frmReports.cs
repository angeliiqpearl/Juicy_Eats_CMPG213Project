﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juicy_Eats_CMPG213Project
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (rbSales.Checked)
            {
                if (rbYes.Checked)
                {
                    //show total for the sales
                }

                else if (rbNo.Checked)
                {
                    //do not show total for the sales
                }
            
            }

            else if (rbInventory.Checked)
            {
                //show the inventory in stock
            
            }
        }

        private void rbInventory_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbSales_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbAscending_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbDescending_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
