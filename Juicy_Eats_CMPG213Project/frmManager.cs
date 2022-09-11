using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Juicy_Eats_CMPG213Project
{
    public partial class frmManager : Form
    {
        public frmManager()
        {
            InitializeComponent();
        }
        string conStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Juicy_Eats;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter adap;
        DataSet setOfData;
        

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin myForm = new frmLogin();
            myForm.Show();
            this.Close();
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hireEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHireEmployees addWindow = new frmHireEmployees();
            addWindow.Show();
            this.Close();
        }

        private void fireEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFireEmployees myFormView = new frmFireEmployees();
            myFormView.Show();
            this.Close();
        }

        private void purchaseInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchaseInventory myFormView = new frmPurchaseInventory();
            myFormView.Show();
            this.Close();
        }

        private void deleteInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleteInventory myFormView = new frmDeleteInventory();
            myFormView.Show();
            this.Close();
        }

        private void addSuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddSupplier myFormView = new frmAddSupplier();
            myFormView.Show();
            this.Close();
        }

        private void deleteSuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleteSupplier myFormView = new frmDeleteSupplier();
            myFormView.Show();
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void viewEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                adap = new SqlDataAdapter();
                setOfData = new DataSet();

                string Sql = "SELECT * FROM EMPLOYEE";   //Select data from SQL table

                comm = new SqlCommand(Sql, conn);  //Connect to database and SQL stat
                adap.SelectCommand = comm;
                adap.Fill(setOfData, "SourceTable");

                dataGridView1.DataSource = setOfData;    //Get data from DataSet
                dataGridView1.DataMember = "SourceTable";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmManager_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            conn.Close();
        }

        private void viewInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                adap = new SqlDataAdapter();
                setOfData = new DataSet();

                string Sql = "SELECT * FROM INVENTORY";   //Select data from SQL table

                comm = new SqlCommand(Sql, conn);  //Connect to database and SQL stat
                adap.SelectCommand = comm;
                adap.Fill(setOfData, "SourceTable");

                dataGridView1.DataSource = setOfData;    //Get data from DataSet
                dataGridView1.DataMember = "SourceTable";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void viewSuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                adap = new SqlDataAdapter();
                setOfData = new DataSet();

                string Sql = "SELECT * FROM SUPPLIER";   //Select data from SQL table

                comm = new SqlCommand(Sql, conn);  //Connect to database and SQL stat
                adap.SelectCommand = comm;
                adap.Fill(setOfData, "SourceTable");

                dataGridView1.DataSource = setOfData;    //Get data from DataSet
                dataGridView1.DataMember = "SourceTable";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmManager_Leave(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            dataGridView1.DataSource = null;
            conn.Close();
        }

        private void updateInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void updateEmployeeDetailsStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddInventory myFormView = new frmAddInventory();
            myFormView.Show();
            this.Close();
        }
    }
}
