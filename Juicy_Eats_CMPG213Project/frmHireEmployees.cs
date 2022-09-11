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
    public partial class frmHireEmployees : Form
    {
        public frmHireEmployees()
        {
            InitializeComponent();
        }

        string conStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Juicy_Eats;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter adap;
        DataSet setOfData;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnHire_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlCommand SqlInsert = new SqlCommand($"INSERT INTO EMPLOYEE(Employee_LName,Employee_FName,Employee_Type) VALUES ('{txtSurname.Text}','{txtName.Text}','{cmbType.Text}')", conn);
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

        private void frmHireEmployees_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            conn.Close();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblType_Click(object sender, EventArgs e)
        {

        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }
    }
}
