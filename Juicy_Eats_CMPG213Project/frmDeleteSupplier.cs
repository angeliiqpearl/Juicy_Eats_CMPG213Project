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
    public partial class frmDeleteSupplier : Form
    {
        public frmDeleteSupplier()
        {
            InitializeComponent();
        }
        string conStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Juicy_Eats;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter adap;
        DataSet setOfData;
        SqlDataReader reader;

        private void frmDeleteSupplier_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            conn.Close();
            try
            {
                conn.Open();
                adap = new SqlDataAdapter();
                setOfData = new DataSet();

                string Sql = "SELECT Supplier_Name FROM SUPPLIER";   //Select data from SQL table

                comm = new SqlCommand(Sql, conn);  //Connect to database and SQL stat
                adap.SelectCommand = comm;
                adap.Fill(setOfData, "SourceTable");

                reader = comm.ExecuteReader();
                cmbSelect.Items.Clear();

                while (reader.Read())
                {
                    cmbSelect.Items.Add(reader.GetValue(0)); //Load the employee surnames into the combobox for selection
                }

                conn.Close();   //Close connection 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string Sql = "DELETE FROM SUPPLIER WHERE Supplier_Name ='" + cmbSelect.Text + "'";   //Delete data from SQL table
                SqlCommand comm = new SqlCommand(Sql, conn);
                SqlDataAdapter adap = new SqlDataAdapter();
                adap.DeleteCommand = comm;
                adap.DeleteCommand.ExecuteNonQuery();
                conn.Close();   //Close connection
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
