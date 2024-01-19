using MySql.Data.MySqlClient;
namespace InventoryManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
            if(checkBox1.Checked == false)
            {
                passwardTb.UseSystemPasswordChar = true;
            }
            else
            {
                passwardTb.UseSystemPasswordChar = false;
            }
        }
    }
}
