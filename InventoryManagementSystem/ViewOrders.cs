using MySql.Data.MySqlClient;
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
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
        }

        string connectionString = "server=localhost;database='inventory_management_db';uid=root;pwd=\"\";";
        MySqlConnection? cnn;

        void populateOrders()

        {
            cnn = new MySqlConnection(connectionString);

            try
            {
                cnn.Open();
                string myquary = "select * from ordertbl";
                MySqlDataAdapter da = new MySqlDataAdapter(myquary, cnn);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                OrdersDataGV.DataSource = ds.Tables[0];
                cnn.Close();
            }
            catch
            {
            }
        }


        private void ViewOrders_Load(object sender, EventArgs e)
        {
            populateOrders();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void OrdersDataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {                
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.DrawString("Order Summary", new Font("Lato", 25, FontStyle.Bold), Brushes.Black, new Point(300,50));
                e.Graphics.DrawString("----------------------------------------------------", new Font("Lato", 25, FontStyle.Bold), Brushes.Black, new Point(80, 80));
                e.Graphics.DrawString("Order Id: " + OrdersDataGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Lato", 16, FontStyle.Regular), Brushes.Black, new Point(200,120));
                e.Graphics.DrawString("Customer Id: " + OrdersDataGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Lato", 16, FontStyle.Regular), Brushes.Black, new Point(200, 160));
                e.Graphics.DrawString("Customer Name: " + OrdersDataGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Lato", 16, FontStyle.Regular), Brushes.Black, new Point(200, 200));
                e.Graphics.DrawString("Order Date: " + OrdersDataGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Lato", 16, FontStyle.Regular), Brushes.Black, new Point(200, 240));
                e.Graphics.DrawString("Total Amount: Rs. " + OrdersDataGV.SelectedRows[0].Cells[4].Value.ToString() + ".00", new Font("Lato", 16, FontStyle.Regular), Brushes.Black, new Point(200, 280));
                e.Graphics.DrawString("----------------------------------------------------", new Font("Lato", 25, FontStyle.Bold), Brushes.Black, new Point(80, 300));
                e.Graphics.DrawString("Developed by Chathura Devinda.2023", new Font("Lato", 12, FontStyle.Bold), Brushes.Black, new Point(280, 340));
            }
            catch (Exception ex)
            {
                MessageBox.Show(""  + ex);
                Console.WriteLine("Error in printDocument1_PrintPage: " + ex.Message);
            }
        }


    }
}
