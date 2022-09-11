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
    public partial class frmFireEmployees : Form
    {
        public frmFireEmployees()
        {
            InitializeComponent();
        }

        string conStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Juicy_Eats;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter adap;
        DataSet setOfData;
        SqlDataReader reader;

        private void frmFireEmployees_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            conn.Close();

            try
            {
                conn.Open();
                adap = new SqlDataAdapter();
                setOfData = new DataSet();

                string Sql = "SELECT * FROM EMPLOYEE";   //Select data from SQL table

                comm = new SqlCommand(Sql, conn);  //Connect to database and SQL stat
                adap.SelectCommand = comm;

                reader = comm.ExecuteReader();
                cmbName.Items.Clear();

                while (reader.Read())
                {
                    cmbName.Items.Add(reader.GetValue(2)); //Load the empployee names into the combobox for selection
                }

                conn.Close();   //Close connection 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblSelect_Click(object sender, EventArgs e)
        {

        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string Sql = "DELETE FROM EMPLOYEE WHERE Employee_LName ='" + cmbSurname.Text + "' AND Employee_FName ='" + cmbName.Text + "'";   //Delete data from SQL table
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

        private void cmbSurname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                adap = new SqlDataAdapter();
                setOfData = new DataSet();

                string Sql = "SELECT * FROM EMPLOYEE WHERE Employee_FName ='" + cmbName.Text + "'";   //Select data from SQL table

                comm = new SqlCommand(Sql, conn);  //Connect to database and SQL stat
                adap.SelectCommand = comm;

                reader = comm.ExecuteReader();
                cmbSurname.Items.Clear();

                while (reader.Read())
                {
                    cmbSurname.Items.Add(reader.GetValue(1)); //Load the empployee surnames into the combobox for selection
                }

                conn.Close();   //Close connection 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
