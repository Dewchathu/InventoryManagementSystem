using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            UserManagement user = new UserManagement();
            this.Hide();
            user.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ManageProducts prod = new ManageProducts();
            this.Hide();
            prod.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ManageCategories cate = new ManageCategories();
            this.Hide();
            cate.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ManageOrders ordr = new ManageOrders();
            this.Hide();
            ordr.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ManageCustomers cust = new ManageCustomers();
            this.Hide();
            cust.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.Show();
        }
    }
}
