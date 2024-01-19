using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InventoryManagementSystem
{
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
        {
            InitializeComponent();
        }

        string connectionString = "server=localhost;database='inventory_management_db';uid=root;pwd=\"\";";
        MySqlConnection? cnn;

        void populate()

        {
            cnn = new MySqlConnection(connectionString);

            try
            {
                cnn.Open();
                string myquary = "select * from custTbl";
                MySqlDataAdapter da = new MySqlDataAdapter(myquary, cnn);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CustomerDataGV.DataSource = ds.Tables[0];
                cnn.Close();
            }
            catch
            {
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnn = new MySqlConnection(connectionString);
            try
            {
                cnn.Open();
                MySqlCommand cmd = new MySqlCommand("insert into custtbl values('" + CustomerIdTb.Text + "','" + CustomerNameTb.Text + "','" + CustomerPhoneTb.Text + "')", cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Sussefully Added.");
                cnn.Close();
                populate();

                CustomerIdTb.Text = "";
                CustomerNameTb.Text = "";
                CustomerPhoneTb.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Open Connection");
            }
        }

        private void CustomerDataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerIdTb.Text = CustomerDataGV.SelectedRows[0].Cells[0].Value.ToString();
            CustomerNameTb.Text = CustomerDataGV.SelectedRows[0].Cells[1].Value.ToString();
            CustomerPhoneTb.Text = CustomerDataGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cnn = new MySqlConnection(connectionString);

            if (CustomerIdTb.Text == "")
            {
                MessageBox.Show("Enter the Customer Id");
            }
            else
            {
                cnn.Open();
                string myquary = "delete from custtbl where CustomerId = '" + CustomerIdTb.Text + "';";
                MySqlCommand cmd = new MySqlCommand(myquary, cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Sussefully Deleted.");
                cnn.Close();
                populate();

                CustomerIdTb.Text = "";
                CustomerNameTb.Text = "";
                CustomerPhoneTb.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cnn = new MySqlConnection(connectionString);
            try
            {
                cnn.Open();
                MySqlCommand cmd = new MySqlCommand("update custtbl set CustomerName='" + CustomerNameTb.Text + "',CustomerPhone='" + CustomerPhoneTb.Text + "' where CustomerId = '" + CustomerIdTb.Text + "'", cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Sussefully Updated.");
                cnn.Close();
                populate();

                CustomerIdTb.Text = "";
                CustomerNameTb.Text = "";
                CustomerPhoneTb.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Open Connection");
            }
        }
    }
    
}
