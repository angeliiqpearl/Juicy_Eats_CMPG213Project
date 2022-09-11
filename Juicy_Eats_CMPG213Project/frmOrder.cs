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
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        string conStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Juicy_Eats;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter adap;
        DataSet setOfData;
        DataTable tableOfData;
        SqlDataReader reader;
        int counter = 1;
        int item = 0;
        double price = 0;
        decimal quantity = 0;
        DateTime date = DateTime.Today;
        //DateTime date = DateTime.ParseExact(DateTime.Today.ToShortDateString(), "yyyy-mm-dd", null);
        double total = 0;
        int employee = 0;
        string item_name;

        public string emp_name, emp_surname;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            emp_name = frmLogin.name;
            emp_surname = frmLogin.surname;
            counter = 1;

            conn = new SqlConnection(conStr);
            conn.Open();
            conn.Close();

            try
            {
                conn.Open();
                adap = new SqlDataAdapter();
                setOfData = new DataSet();

                string Sql = "SELECT Inventory_Description,Sales_Price FROM INVENTORY WHERE Inventory_Qty > 0";   //Select data from SQL table

                comm = new SqlCommand(Sql, conn);  //Connect to database and SQL stat
                adap.SelectCommand = comm;

                reader = comm.ExecuteReader();
                cmbItem.Items.Clear();

                while (reader.Read())
                {
                    lstAvailable.Items.Add(reader.GetString(0)+"\t"+reader.GetDecimal(1)); //Load the availabe items' name into the listbox 
                    cmbItem.Items.Add(reader.GetValue(0)); //Load the item names into the combobox for selection
                }

                conn.Close();   //Close connection 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                adap = new SqlDataAdapter();
                setOfData = new DataSet();

                string Sql = "SELECT Employee_ID FROM EMPLOYEE WHERE Employee_LName ='" + emp_surname + "' AND Employee_FName ='" + emp_name + "'";   //Select data from SQL table

                comm = new SqlCommand(Sql, conn);  //Connect to database and SQL stat
                adap.SelectCommand = comm;

                reader = comm.ExecuteReader();

                if (reader.Read())
                {
                    employee = reader.GetInt32(0); 
                }

                conn.Close();   //Close connection 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }

            try
            {
                conn.Open();
                adap = new SqlDataAdapter();
                setOfData = new DataSet();

                string sql = "SELECT Inventory_ID,Inventory_Description,Sales_Price FROM INVENTORY WHERE Inventory_Description ='" + cmbItem.Text + "'";   //Select data from SQL table

                comm = new SqlCommand(sql, conn);  //Connect to database and SQL stat
                adap.SelectCommand = comm;

                reader = comm.ExecuteReader();

                if (reader.Read())
                {
                    item = reader.GetInt32(0);
                    price = Decimal.ToDouble(reader.GetDecimal(2));
                    quantity = numQuantity.Value;
                    total = price * Decimal.ToDouble(quantity);
                    item_name = reader.GetString(1);


                }

                conn.Close();   //Close connection 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }

            try
            {
                conn.Open();

                SqlCommand SqlInsert = new SqlCommand($"INSERT INTO SALES_DETAIL(Employee_ID,Inventory_ID,Sales_Price,Sales_Qty,Sales_Orderdate,Sales_OrderTotal) VALUES ({employee},{item},{price},{quantity},'{date.ToShortDateString()}',{total})", conn);
                adap = new SqlDataAdapter();
                adap.InsertCommand = SqlInsert;
                adap.InsertCommand.ExecuteNonQuery();
                conn.Close();
                lstOrders.Items.Add("Order #" + counter + "\n Details: " + quantity + "x " + item_name);
                counter++;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin myForm = new frmLogin();
            myForm.Show();
            this.Close();
        }

        private void lstCart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
