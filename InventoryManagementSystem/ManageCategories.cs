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
    public partial class ManageCategories : Form
    {
        public ManageCategories()
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
                string myquary = "select * from categorytbl";
                MySqlDataAdapter da = new MySqlDataAdapter(myquary, cnn);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                categoryDataGV.DataSource = ds.Tables[0];
                cnn.Close();
            }
            catch
            {
                MessageBox.Show("Cannot Open Connection");
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
                MySqlCommand cmd = new MySqlCommand("insert into categorytbl values('" + CategoryIdTb.Text + "','" + categoryNameTb.Text + "')", cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Sussefully Added.");
                cnn.Close();
                populate();

                CategoryIdTb.Text = "";
                categoryNameTb.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Open Connection");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cnn = new MySqlConnection(connectionString);

            if (CategoryIdTb.Text == "")
            {
                MessageBox.Show("Enter the Category ID");
            }
            else
            {
                cnn.Open();
                string myquary = "delete from categorytbl where CategoryId = '" + CategoryIdTb.Text + "';";
                MySqlCommand cmd = new MySqlCommand(myquary, cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Sussefully Deleted.");
                cnn.Close();
                populate();

                CategoryIdTb.Text = "";
                categoryNameTb.Text = "";
            }
        }

        private void categoryDataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CategoryIdTb.Text = categoryDataGV.SelectedRows[0].Cells[0].Value.ToString();
            categoryNameTb.Text = categoryDataGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void ManageCategories_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cnn = new MySqlConnection(connectionString);
            try
            {
                cnn.Open();
                MySqlCommand cmd = new MySqlCommand("update categorytbl set CategoryName='" + categoryNameTb.Text + "' where CategoryId = '" + CategoryIdTb.Text + "'", cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Sussefully Updated.");
                cnn.Close();
                populate();

                CategoryIdTb.Text = "";
                categoryNameTb.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Open Connection");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            this.Hide();
            home.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CategoryIdTb.Text = "";
            categoryNameTb.Text = "";
        }
    }
}
