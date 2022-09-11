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
    public partial class frmAddSupplier : Form
    {
        public frmAddSupplier()
        {
            InitializeComponent();
        }

        string conStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Juicy_Eats;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter adap;
        DataSet setOfData;

        private void btnHire_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlCommand SqlInsert = new SqlCommand($"INSERT INTO SUPPLIER(Supplier_Name,Supplier_Email,Supplier_PhoneNo,Supplier_Type) VALUES ('{txtName.Text}','{txtEmail.Text}','{txtPhone.Text}','{cmbType.Text}')", conn);
                adap = new SqlDataAdapter();
                adap.InsertCommand = SqlInsert;
                adap.InsertCommand.ExecuteNonQuery();
                conn.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmAddSupplier_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            conn.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmManager myForm = new frmManager();
            myForm.Show();
            this.Close();
        }
    }
}
