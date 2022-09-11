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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        string conStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Juicy_Eats;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter adap;
        DataSet setOfData;
        DataTable tableOfData;

        public static string name = " ";
        public static string surname = " ";
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                adap = new SqlDataAdapter();
                setOfData = new DataSet();
                tableOfData = new DataTable();

                string Sql = "SELECT Employee_FName FROM EMPLOYEE WHERE Employee_FName ='" + txtName.Text + "'";   //Select data from SQL table

                comm = new SqlCommand(Sql, conn);  //Connect to database and SQL stat
                adap.SelectCommand = comm;
                adap.Fill(setOfData, "SourceTable");

                tableOfData = setOfData.Tables[0];
                if (tableOfData.Rows.Count == 0)
                {
                    MessageBox.Show("The name entered is incorrect. Please try again.");
                    txtName.Text = " ";
                    txtName.Focus();
                    conn.Close();
                }
                else
                {
                    conn.Close();
                    try
                    {
                        conn.Open();
                        adap = new SqlDataAdapter();
                        setOfData = new DataSet();
                        tableOfData = new DataTable();

                        string sql = "SELECT Employee_LName FROM EMPLOYEE WHERE Employee_FName ='" + txtName.Text + "' AND Employee_LName ='" + txtSurname.Text + "'";   //Select data from SQL table

                        comm = new SqlCommand(sql, conn);  //Connect to database and SQL stat
                        adap.SelectCommand = comm;
                        adap.Fill(setOfData, "SourceTable");

                        tableOfData = setOfData.Tables[0];
                        if (tableOfData.Rows.Count == 0)
                        {
                            MessageBox.Show("The surname entered is incorrect. Please try again.");
                            txtSurname.Text = " ";
                            txtSurname.Focus();
                            conn.Close();
                        }
                        else
                        {
                            conn.Close();
                            try
                            {
                                conn.Open();
                                adap = new SqlDataAdapter();
                                setOfData = new DataSet();
                                tableOfData = new DataTable();

                                string sqlStatus = "SELECT Employee_Type FROM EMPLOYEE WHERE Employee_FName ='" + txtName.Text + "' AND Employee_LName ='" + txtSurname.Text + "'";   //Select data from SQL table

                                comm = new SqlCommand(sqlStatus, conn);  //Connect to database and SQL stat
                                adap.SelectCommand = comm;
                                adap.Fill(setOfData, "SourceTable");

                                tableOfData = setOfData.Tables[0];
                                if (tableOfData.Rows[0][0].ToString() == "Cashier")
                                {
                                    name = txtName.Text;
                                    surname = txtSurname.Text;
                                    frmOrder myForm = new frmOrder();
                                    txtName.Text = " ";
                                    txtSurname.Text = " ";
                                    myForm.Show();
                                    this.Hide();
                                }
                                else if (tableOfData.Rows[0][0].ToString() == "Manager")
                                {
                                    frmManager myForm = new frmManager();
                                    myForm.Show();
                                    this.Hide();
                                }

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            conn.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
