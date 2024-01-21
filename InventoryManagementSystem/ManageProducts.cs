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
    public partial class ManageProducts : Form
    {
        public ManageProducts()
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
                string myquary = "select * from producttbl";
                MySqlDataAdapter da = new MySqlDataAdapter(myquary, cnn);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductDataGV.DataSource = ds.Tables[0];
                cnn.Close();
            }
            catch
            {
            }
        }

        void filterByCategory()

        {
            cnn = new MySqlConnection(connectionString);

            try
            {
                cnn.Open();
                string myquary = "select * from producttbl where ProductCat = '" + SearchCombo.SelectedValue.ToString() + "'";
                MySqlDataAdapter da = new MySqlDataAdapter(myquary, cnn);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductDataGV.DataSource = ds.Tables[0];
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
        }

        void fillCategory()
        {
            cnn = new MySqlConnection(connectionString);
            string query = "select * from categorytbl";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader rdr;

            try
            {
                cnn.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CategoryName", typeof(String));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                cateCombo.ValueMember = "CategoryName";
                cateCombo.DataSource = dt;
                SearchCombo.ValueMember = "CategoryName";
                SearchCombo.DataSource = dt;
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {
            fillCategory();
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnn = new MySqlConnection(connectionString);
            try
            {
                cnn.Open();
                MySqlCommand cmd = new MySqlCommand("insert into producttbl values('" + ProductIdTb.Text + "','" + ProductNameTb.Text + "','" + ProductQtyTb.Text + "', '" + ProductPriceTb.Text + "', '" + DescriptionTb.Text + "', '" + cateCombo.SelectedValue.ToString() + "')", cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Sussefully Added.");
                cnn.Close();
                populate();

                ProductIdTb.Text = "";
                ProductNameTb.Text = "";
                ProductQtyTb.Text = "";
                ProductPriceTb.Text = "";
                DescriptionTb.Text = "";
                cateCombo.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Open Connection");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cnn = new MySqlConnection(connectionString);

            if (ProductIdTb.Text == "")
            {
                MessageBox.Show("Enter the Product Id");
            }
            else
            {
                cnn.Open();
                string myquary = "delete from producttbl where ProductId = '" + ProductIdTb.Text + "';";
                MySqlCommand cmd = new MySqlCommand(myquary, cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Sussefully Deleted.");
                cnn.Close();
                populate();

                ProductIdTb.Text = "";
                ProductNameTb.Text = "";
                ProductQtyTb.Text = "";
                ProductPriceTb.Text = "";
                DescriptionTb.Text = "";
                cateCombo.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cnn = new MySqlConnection(connectionString);
            try
            {
                cnn.Open();
                MySqlCommand cmd = new MySqlCommand("update producttbl set ProductName='" + ProductNameTb.Text + "',ProductQty='" + ProductQtyTb.Text + "', ProductPrice='" + ProductPriceTb.Text + "', ProductDes = '" + DescriptionTb.Text + "', ProductCat = '" + cateCombo.Text + "'  where ProductId = '" + ProductIdTb.Text + "'", cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Sussefully Updated.");
                cnn.Close();
                populate();

                ProductIdTb.Text = "";
                ProductNameTb.Text = "";
                ProductQtyTb.Text = "";
                ProductPriceTb.Text = "";
                DescriptionTb.Text = "";
                cateCombo.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Open Connection" + ex);
            }
        }

        private void ProductDataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductIdTb.Text = ProductDataGV.SelectedRows[0].Cells[0].Value.ToString();
            ProductNameTb.Text = ProductDataGV.SelectedRows[0].Cells[1].Value.ToString();
            ProductQtyTb.Text = ProductDataGV.SelectedRows[0].Cells[2].Value.ToString();
            ProductPriceTb.Text = ProductDataGV.SelectedRows[0].Cells[3].Value.ToString();
            DescriptionTb.Text = ProductDataGV.SelectedRows[0].Cells[4].Value.ToString();
            cateCombo.Text = ProductDataGV.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            filterByCategory();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            populate();
            ProductIdTb.Text = "";
            ProductNameTb.Text = "";
            ProductQtyTb.Text = "";
            ProductPriceTb.Text = "";
            DescriptionTb.Text = "";
            cateCombo.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            this.Hide();
            home.Show();
        }
    }
}
