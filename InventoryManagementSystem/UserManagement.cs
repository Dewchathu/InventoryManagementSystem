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
    public partial class UserManagement : Form
    {
        public UserManagement()
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
                string myquary = "select * from userTbl";
                MySqlDataAdapter da = new MySqlDataAdapter(myquary, cnn);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                userDataGV.DataSource = ds.Tables[0];
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UnameTb.Text = userDataGV.SelectedRows[0].Cells[0].Value.ToString();
            UfullNameTb.Text = userDataGV.SelectedRows[0].Cells[1].Value.ToString();
            UpasswardTb.Text = userDataGV.SelectedRows[0].Cells[2].Value.ToString();
            UphoneTb.Text = userDataGV.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnn = new MySqlConnection(connectionString);
            try
            {
                cnn.Open();
                MySqlCommand cmd = new MySqlCommand("insert into usertbl values('" + UnameTb.Text + "','" + UfullNameTb.Text + "','" + UpasswardTb.Text + "','" + UphoneTb.Text + "')", cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Sussefully Added.");
                cnn.Close();
                populate();

                UnameTb.Text = "";
                UfullNameTb.Text = "";
                UpasswardTb.Text = "";
                UphoneTb.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Open Connection" + ex);
            }
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)

        {
            cnn = new MySqlConnection(connectionString);

            if (UphoneTb.Text == "")
            {
                MessageBox.Show("Enter the Users phone number");
            }
            else
            {
                cnn.Open();
                string myquary = "delete from usertbl where Uphone = '" + UphoneTb.Text + "';";
                MySqlCommand cmd = new MySqlCommand(myquary, cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Sussefully Deleted.");
                cnn.Close();
                populate();

                UnameTb.Text = "";
                UfullNameTb.Text = "";
                UpasswardTb.Text = "";
                UphoneTb.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cnn = new MySqlConnection(connectionString);
            try
            {
                cnn.Open();
                MySqlCommand cmd = new MySqlCommand("update usertbl set Uname='" + UnameTb.Text + "',Ufullname='" + UfullNameTb.Text + "',Upassward='" + UpasswardTb.Text + "' where Uphone = '" + UphoneTb.Text + "'", cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Sussefully Updated.");
                cnn.Close();
                populate();

                UnameTb.Text = "";
                UfullNameTb.Text = "";
                UpasswardTb.Text = "";
                UphoneTb.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Open Connection" + ex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            this.Hide();
            home.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UnameTb.Text = "";
            UfullNameTb.Text = "";
            UpasswardTb.Text = "";
            UphoneTb.Text = "";
        }
    }
}
