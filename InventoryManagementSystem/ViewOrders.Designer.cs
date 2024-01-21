namespace InventoryManagementSystem
{
    partial class ViewOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOrders));
            label1 = new Label();
            panel1 = new Panel();
            OrdersDataGV = new DataGridView();
            button1 = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lato", 16.1999989F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(487, 45);
            label1.Name = "label1";
            label1.Size = new Size(166, 33);
            label1.TabIndex = 0;
            label1.Text = "View Orders";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(81, 191, 164);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Lato", 16.1999989F, FontStyle.Bold);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1164, 125);
            panel1.TabIndex = 4;
            // 
            // OrdersDataGV
            // 
            OrdersDataGV.AllowUserToAddRows = false;
            OrdersDataGV.AllowUserToDeleteRows = false;
            OrdersDataGV.AllowUserToResizeColumns = false;
            OrdersDataGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OrdersDataGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            OrdersDataGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OrdersDataGV.BackgroundColor = Color.White;
            OrdersDataGV.BorderStyle = BorderStyle.None;
            OrdersDataGV.CellBorderStyle = DataGridViewCellBorderStyle.None;
            OrdersDataGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(81, 191, 164);
            dataGridViewCellStyle2.Font = new Font("Lato Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(81, 191, 164);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            OrdersDataGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            OrdersDataGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Lato Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            OrdersDataGV.DefaultCellStyle = dataGridViewCellStyle3;
            OrdersDataGV.EditMode = DataGridViewEditMode.EditProgrammatically;
            OrdersDataGV.EnableHeadersVisualStyles = false;
            OrdersDataGV.GridColor = Color.White;
            OrdersDataGV.Location = new Point(92, 185);
            OrdersDataGV.MultiSelect = false;
            OrdersDataGV.Name = "OrdersDataGV";
            OrdersDataGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            OrdersDataGV.RowHeadersVisible = false;
            OrdersDataGV.RowHeadersWidth = 51;
            OrdersDataGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OrdersDataGV.ShowCellErrors = false;
            OrdersDataGV.ShowCellToolTips = false;
            OrdersDataGV.ShowEditingIcon = false;
            OrdersDataGV.ShowRowErrors = false;
            OrdersDataGV.Size = new Size(959, 409);
            OrdersDataGV.TabIndex = 34;
            OrdersDataGV.CellContentClick += OrdersDataGV_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(81, 191, 164);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(510, 614);
            button1.Name = "button1";
            button1.Size = new Size(121, 38);
            button1.TabIndex = 37;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // ViewOrders
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1164, 752);
            Controls.Add(button1);
            Controls.Add(OrdersDataGV);
            Controls.Add(panel1);
            Font = new Font("Lato Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewOrders";
            Load += ViewOrders_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private DataGridView OrdersDataGV;
        private Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}