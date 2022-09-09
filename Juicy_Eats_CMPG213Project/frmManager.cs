using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juicy_Eats_CMPG213Project
{
    public partial class frmManager : Form
    {
        public frmManager()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hireEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHireEmployees myFormView = new frmHireEmployees();
            myFormView.MdiParent = this;
            myFormView.ShowDialog();
        }

        private void fireEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFireEmployees myFormView = new frmFireEmployees();
            myFormView.MdiParent = this;
            myFormView.ShowDialog();
        }

        private void purchaseInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchaseInventory myFormView = new frmPurchaseInventory();
            myFormView.MdiParent = this;
            myFormView.ShowDialog();
        }

        private void deleteInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleteInventory myFormView = new frmDeleteInventory();
            myFormView.MdiParent = this;
            myFormView.ShowDialog();
        }

        private void addSuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddSupplier myFormView = new frmAddSupplier();
            myFormView.MdiParent = this;
            myFormView.ShowDialog();
        }

        private void deleteSuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleteSupplier myFormView = new frmDeleteSupplier();
            myFormView.MdiParent = this;
            myFormView.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void viewEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
