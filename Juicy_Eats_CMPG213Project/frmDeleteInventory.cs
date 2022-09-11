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
    public partial class frmDeleteInventory : Form
    {
        public frmDeleteInventory()
        {
            InitializeComponent();
        }

        string conStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Juicy_Eats;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter adap;
        DataSet setOfData;
        SqlDataReader reader;

        private void frmDeleteInventory_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            conn.Close();
            try
            {
                conn.Open();
                adap = new SqlDataAdapter();
                setOfData = new DataSet();

                string Sql = "SELECT Inventory_Description FROM INVENTORY";   //Select data from SQL table

                comm = new SqlCommand(Sql, conn);  //Connect to database and SQL stat
                adap.SelectCommand = comm;
                adap.Fill(setOfData, "SourceTable");

                reader = comm.ExecuteReader();
                cmbName.Items.Clear();

                while (reader.Read())
                {
                    cmbName.Items.Add(reader.GetValue(0)); //Load the empployee surnames into the combobox for selection
                }

                conn.Close();   //Close connection 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                adap = new SqlDataAdapter();
                setOfData = new DataSet();

                string Sql = "SELECT Inventory_Qty FROM INVENTORY WHERE Inventory_Description ='" + cmbName.Text + "'";   //Select data from SQL table

                comm = new SqlCommand(Sql, conn);  //Connect to database and SQL stat
                adap.SelectCommand = comm;
                adap.Fill(setOfData, "SourceTable");

                reader = comm.ExecuteReader();
                cmbName.Items.Clear();
                
                if (reader.Read())
                {
                    int current_quantity = reader.GetInt32(0);
                    int remove = (int)numQuantity.Value;
                    int update = current_quantity-remove;
                    conn.Close();
                    try
                    {
                        conn.Open();
                        adap = new SqlDataAdapter();
                        setOfData = new DataSet();

                        string sql = "UPDATE INVENTORY SET Inventory_Qty =" + update + "WHERE Inventory_Description ='" + cmbName.Text + "'";   //Select data from SQL table
                        
                        comm = new SqlCommand(sql, conn);  //Connect to database and SQL stat
                        adap.UpdateCommand = comm;
                        adap.UpdateCommand.ExecuteNonQuery();
                        conn.Close();   //Close connection
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        conn.Close();
                    }
                }
                conn.Close();   //Close connection 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }

        }
    }
}
