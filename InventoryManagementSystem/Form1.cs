using MySql.Data.MySqlClient;
using System.Data;
namespace InventoryManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string connectionString = "server=localhost;database='inventory_management_db';uid=root;pwd=\"\";";
        MySqlConnection? cnn;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            userNameTb.Text = "";
            passwardTb.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                passwardTb.UseSystemPasswordChar = true;
            }
            else
            {
                passwardTb.UseSystemPasswordChar = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnn = new MySqlConnection(connectionString);

            try
            {
                cnn.Open();
                string myquary = "select Count(*) from usertbl where Uname = '" + userNameTb.Text + "' and Upassward = '" + passwardTb.Text + "'";
                MySqlDataAdapter da = new MySqlDataAdapter(myquary, cnn);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
                DataTable ds = new DataTable();
                da.Fill(ds);
                if (ds.Rows[0][0].ToString() == "1")
                {
                    HomeForm home = new HomeForm();
                    this.Hide();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Username or Passward incorrect");
                }
                cnn.Close();
            }
            catch
            {
                MessageBox.Show("Cannot Open Connection");
            }
        }
    }
}
