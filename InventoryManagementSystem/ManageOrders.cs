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
using MySqlX.XDevAPI.Relational;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventoryManagementSystem
{
    public partial class ManageOrders : Form
    {


        public ManageOrders()
        {
            InitializeComponent();

            table.Columns.Add("No", typeof(int));
            table.Columns.Add("Product", typeof(string));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("UnitPrice", typeof(int));
            table.Columns.Add("TotalPrice", typeof(int));
        }

        string connectionString = "server=localhost;database='inventory_management_db';uid=root;pwd=\"\";";
        MySqlConnection? cnn;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void SetNextOrderId()
        {
            cnn = new MySqlConnection(connectionString);

            try
            {
                cnn.Open();
                string query = "SELECT MAX(OrderId) FROM ordertbl";
                MySqlCommand cmd = new MySqlCommand(query, cnn);
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    int lastOrderId = Convert.ToInt32(result);
                    OrderIdTb.Text = (lastOrderId + 1).ToString();
                }
                else
                {

                    OrderIdTb.Text = "1";
                }

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving OrderId: " + ex.Message);
            }
        }

        void populate()

        {
            cnn = new MySqlConnection(connectionString);

            try
            {
                cnn.Open();
                string myquary = "select * from custtbl";
                MySqlDataAdapter da = new MySqlDataAdapter(myquary, cnn);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CustomersDataGV.DataSource = ds.Tables[0];
                cnn.Close();
            }
            catch
            {
            }
        }

        void populateProducts()

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
                ProductsDataGV.DataSource = ds.Tables[0];
                cnn.Close();
            }
            catch
            {
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
                SearchCombo.ValueMember = "CategoryName";
                SearchCombo.DataSource = dt;
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
        }

        int flag = 0;
        int stock;

        private void UpdateProductStock()
        {
            cnn = new MySqlConnection(connectionString);


            int id = Convert.ToInt32(ProductsDataGV.SelectedRows[0].Cells[0].Value.ToString());
            int newQty = stock - qty;

            if (newQty < 0)
                MessageBox.Show("Opperation Faild.");
            else
            {

                cnn.Open();
                string quary = "update producttbl set ProductQty = " + newQty + " where ProductId = " + id + ";";

                MySqlCommand cmd = new MySqlCommand(quary, cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();

                populateProducts();
            }
        }

        int num = 0;
        int uPrice, totPrice, qty;
        string product;
        DataTable table = new DataTable();


        private void ManageOrders_Load(object sender, EventArgs e)
        {
            populate();
            populateProducts();
            fillCategory();
            SetNextOrderId();
        }

        private void CustomersDataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerIdTb.Text = CustomersDataGV.SelectedRows[0].Cells[0].Value.ToString();
            CustomerNameTb.Text = CustomersDataGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void SearchCombo_SelectionChangeCommitted(object sender, EventArgs e)
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
                ProductsDataGV.DataSource = ds.Tables[0];
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
        }

        private void OrderIdTb_TextChanged(object sender, EventArgs e)
        {

        }


        private void ProductsDataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            product = ProductsDataGV.SelectedRows[0].Cells[1].Value.ToString();
            uPrice = Convert.ToInt32(ProductsDataGV.SelectedRows[0].Cells[3].Value.ToString());
            stock = Convert.ToInt32(ProductsDataGV.SelectedRows[0].Cells[2].Value.ToString());
            flag = 1;
        }
        int sum = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            if (QtyTb.Text == "")
            {
                MessageBox.Show("Enter the Quantity of Products.");
            }
            else if (flag == 0)
            {
                MessageBox.Show("Select the product");
            }
            else if (Convert.ToInt32(QtyTb.Text) > stock)
            {
                MessageBox.Show("Not Enough Stock Available.");
            }
            else
            {
                num = num + 1;
                qty = Convert.ToInt32(QtyTb.Text);
                totPrice = qty * uPrice;
                table.Rows.Add(num, product, qty, uPrice, totPrice);
                OrderGV.DataSource = table;
                flag = 0;
                QtyTb.Text = "";
                sum = sum + totPrice;
                TotalAmount.Text = "Rs" + sum.ToString();


                UpdateProductStock();
            }
        }



        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (OrderIdTb.Text == "" || CustomerIdTb.Text == "" || TotalAmount.Text == "")
            {
                MessageBox.Show("Fill the Data Correctly.");
            }
            else
            {

                cnn = new MySqlConnection(connectionString);

                try
                {
                    cnn.Open();
                    MySqlCommand cmd = new MySqlCommand("insert into ordertbl values(" + OrderIdTb.Text + "," + CustomerIdTb.Text + ",'" + CustomerNameTb.Text + "', '" + OrderDate.Value.Date.ToString("yyyy-MM-dd HH:mm") + "', " + sum + ")", cnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Sussefully Added.");
                    cnn.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot Open Connection" + ex);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewOrders view = new ViewOrders();
            view.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            this.Hide();
            home.Show();
        }
    }
}
