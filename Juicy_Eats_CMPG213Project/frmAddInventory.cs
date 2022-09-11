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
    public partial class frmAddInventory : Form
    {
        public frmAddInventory()
        {
            InitializeComponent();
        }

        string conStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Juicy_Eats;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn;
        SqlDataAdapter adap;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPrice.Text, out decimal price))
            {
                try
                {
                    conn.Open();

                    SqlCommand SqlInsert = new SqlCommand($"INSERT INTO INVENTORY(Inventory_Description,Inventory_Qty,Sales_Price) VALUES ('{txtName.Text}',{numQuantity.Value},{price})", conn);
                    adap = new SqlDataAdapter();
                    adap.InsertCommand = SqlInsert;
                    adap.InsertCommand.ExecuteNonQuery();
                    conn.Close();
                    frmManager myForm = new frmManager();
                    myForm.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a number for the price.");
                txtPrice.Text = " ";
                txtPrice.Focus();
            }
        }

        private void frmAddInventory_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            conn.Close();
        }
    }
}
