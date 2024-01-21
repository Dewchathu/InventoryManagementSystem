namespace InventoryManagementSystem
{
    partial class ManageOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageOrders));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            CustomersDataGV = new DataGridView();
            label8 = new Label();
            OrderIdTb = new TextBox();
            CustomerIdTb = new TextBox();
            label011 = new Label();
            label3 = new Label();
            OrderDate = new DateTimePicker();
            label4 = new Label();
            ProductsDataGV = new DataGridView();
            SearchCombo = new ComboBox();
            label5 = new Label();
            CustomerNameTb = new TextBox();
            QtyTb = new TextBox();
            label6 = new Label();
            button4 = new Button();
            OrderGV = new DataGridView();
            label7 = new Label();
            TotalAmount = new Label();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomersDataGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductsDataGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrderGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(81, 191, 164);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Lato", 16.1999989F, FontStyle.Bold);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1164, 125);
            panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1124, 12);
            pictureBox2.Margin = new Padding(2, 3, 2, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lato", 18F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(350, 27);
            label2.Name = "label2";
            label2.Size = new Size(448, 36);
            label2.TabIndex = 0;
            label2.Text = "Inventory Managements System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lato", 16.1999989F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(459, 63);
            label1.Name = "label1";
            label1.Size = new Size(201, 33);
            label1.TabIndex = 0;
            label1.Text = "Manage Orders";
            // 
            // CustomersDataGV
            // 
            CustomersDataGV.AllowUserToAddRows = false;
            CustomersDataGV.AllowUserToDeleteRows = false;
            CustomersDataGV.AllowUserToResizeColumns = false;
            CustomersDataGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomersDataGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            CustomersDataGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CustomersDataGV.BackgroundColor = Color.White;
            CustomersDataGV.BorderStyle = BorderStyle.None;
            CustomersDataGV.CellBorderStyle = DataGridViewCellBorderStyle.None;
            CustomersDataGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(81, 191, 164);
            dataGridViewCellStyle2.Font = new Font("Lato Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(81, 191, 164);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            CustomersDataGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            CustomersDataGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Lato Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            CustomersDataGV.DefaultCellStyle = dataGridViewCellStyle3;
            CustomersDataGV.EditMode = DataGridViewEditMode.EditProgrammatically;
            CustomersDataGV.EnableHeadersVisualStyles = false;
            CustomersDataGV.GridColor = Color.White;
            CustomersDataGV.Location = new Point(30, 185);
            CustomersDataGV.MultiSelect = false;
            CustomersDataGV.Name = "CustomersDataGV";
            CustomersDataGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            CustomersDataGV.RowHeadersVisible = false;
            CustomersDataGV.RowHeadersWidth = 51;
            CustomersDataGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CustomersDataGV.ShowCellErrors = false;
            CustomersDataGV.ShowCellToolTips = false;
            CustomersDataGV.ShowEditingIcon = false;
            CustomersDataGV.ShowRowErrors = false;
            CustomersDataGV.Size = new Size(397, 250);
            CustomersDataGV.TabIndex = 26;
            CustomersDataGV.CellContentClick += CustomersDataGV_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lato", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(131, 139);
            label8.Name = "label8";
            label8.Size = new Size(193, 33);
            label8.TabIndex = 25;
            label8.Text = "Customers List";
            // 
            // OrderIdTb
            // 
            OrderIdTb.BorderStyle = BorderStyle.FixedSingle;
            OrderIdTb.Location = new Point(52, 476);
            OrderIdTb.Name = "OrderIdTb";
            OrderIdTb.Size = new Size(238, 31);
            OrderIdTb.TabIndex = 28;
            OrderIdTb.TextChanged += OrderIdTb_TextChanged;
            // 
            // CustomerIdTb
            // 
            CustomerIdTb.BorderStyle = BorderStyle.FixedSingle;
            CustomerIdTb.Location = new Point(52, 547);
            CustomerIdTb.Name = "CustomerIdTb";
            CustomerIdTb.Size = new Size(238, 31);
            CustomerIdTb.TabIndex = 27;
            // 
            // label011
            // 
            label011.AutoSize = true;
            label011.Location = new Point(52, 449);
            label011.Name = "label011";
            label011.Size = new Size(84, 24);
            label011.TabIndex = 30;
            label011.Text = "Order Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 520);
            label3.Name = "label3";
            label3.Size = new Size(118, 24);
            label3.TabIndex = 29;
            label3.Text = "Customer Id";
            // 
            // OrderDate
            // 
            OrderDate.CalendarFont = new Font("Lato", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OrderDate.Font = new Font("Lato", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OrderDate.Location = new Point(52, 701);
            OrderDate.Name = "OrderDate";
            OrderDate.Size = new Size(238, 23);
            OrderDate.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 669);
            label4.Name = "label4";
            label4.Size = new Size(110, 24);
            label4.TabIndex = 29;
            label4.Text = "Order Date";
            // 
            // ProductsDataGV
            // 
            ProductsDataGV.AllowUserToAddRows = false;
            ProductsDataGV.AllowUserToDeleteRows = false;
            ProductsDataGV.AllowUserToResizeColumns = false;
            ProductsDataGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductsDataGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            ProductsDataGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductsDataGV.BackgroundColor = Color.White;
            ProductsDataGV.BorderStyle = BorderStyle.None;
            ProductsDataGV.CellBorderStyle = DataGridViewCellBorderStyle.None;
            ProductsDataGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(81, 191, 164);
            dataGridViewCellStyle5.Font = new Font("Lato Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(81, 191, 164);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            ProductsDataGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            ProductsDataGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Lato Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            ProductsDataGV.DefaultCellStyle = dataGridViewCellStyle6;
            ProductsDataGV.EditMode = DataGridViewEditMode.EditProgrammatically;
            ProductsDataGV.EnableHeadersVisualStyles = false;
            ProductsDataGV.GridColor = Color.White;
            ProductsDataGV.Location = new Point(459, 185);
            ProductsDataGV.MultiSelect = false;
            ProductsDataGV.Name = "ProductsDataGV";
            ProductsDataGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ProductsDataGV.RowHeadersVisible = false;
            ProductsDataGV.RowHeadersWidth = 51;
            ProductsDataGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductsDataGV.ShowCellErrors = false;
            ProductsDataGV.ShowCellToolTips = false;
            ProductsDataGV.ShowEditingIcon = false;
            ProductsDataGV.ShowRowErrors = false;
            ProductsDataGV.Size = new Size(682, 250);
            ProductsDataGV.TabIndex = 33;
            ProductsDataGV.CellContentClick += ProductsDataGV_CellContentClick;
            // 
            // SearchCombo
            // 
            SearchCombo.FormattingEnabled = true;
            SearchCombo.Location = new Point(682, 143);
            SearchCombo.Name = "SearchCombo";
            SearchCombo.Size = new Size(236, 32);
            SearchCombo.TabIndex = 32;
            SearchCombo.SelectionChangeCommitted += SearchCombo_SelectionChangeCommitted;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 597);
            label5.Name = "label5";
            label5.Size = new Size(154, 24);
            label5.TabIndex = 29;
            label5.Text = "Customer Name";
            // 
            // CustomerNameTb
            // 
            CustomerNameTb.BorderStyle = BorderStyle.FixedSingle;
            CustomerNameTb.Location = new Point(52, 624);
            CustomerNameTb.Name = "CustomerNameTb";
            CustomerNameTb.Size = new Size(238, 31);
            CustomerNameTb.TabIndex = 27;
            // 
            // QtyTb
            // 
            QtyTb.BorderStyle = BorderStyle.FixedSingle;
            QtyTb.Location = new Point(617, 449);
            QtyTb.Name = "QtyTb";
            QtyTb.Size = new Size(238, 31);
            QtyTb.TabIndex = 28;
            QtyTb.TextChanged += OrderIdTb_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(507, 451);
            label6.Name = "label6";
            label6.Size = new Size(88, 24);
            label6.TabIndex = 30;
            label6.Text = "Quantity";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(81, 191, 164);
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(881, 444);
            button4.Name = "button4";
            button4.Size = new Size(165, 38);
            button4.TabIndex = 34;
            button4.Text = "Add to Order";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // OrderGV
            // 
            OrderGV.AllowUserToAddRows = false;
            OrderGV.AllowUserToDeleteRows = false;
            OrderGV.AllowUserToResizeColumns = false;
            OrderGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OrderGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            OrderGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OrderGV.BackgroundColor = Color.White;
            OrderGV.BorderStyle = BorderStyle.None;
            OrderGV.CellBorderStyle = DataGridViewCellBorderStyle.None;
            OrderGV.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            OrderGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(81, 191, 164);
            dataGridViewCellStyle8.Font = new Font("Lato Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(81, 191, 164);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            OrderGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            OrderGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Lato Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            OrderGV.DefaultCellStyle = dataGridViewCellStyle9;
            OrderGV.EditMode = DataGridViewEditMode.EditProgrammatically;
            OrderGV.EnableHeadersVisualStyles = false;
            OrderGV.GridColor = Color.White;
            OrderGV.Location = new Point(342, 497);
            OrderGV.MultiSelect = false;
            OrderGV.Name = "OrderGV";
            OrderGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            OrderGV.RowHeadersVisible = false;
            OrderGV.RowHeadersWidth = 51;
            OrderGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OrderGV.ShowCellErrors = false;
            OrderGV.ShowCellToolTips = false;
            OrderGV.ShowEditingIcon = false;
            OrderGV.ShowRowErrors = false;
            OrderGV.Size = new Size(789, 188);
            OrderGV.TabIndex = 33;
            OrderGV.CellContentClick += ProductsDataGV_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(785, 707);
            label7.Name = "label7";
            label7.Size = new Size(117, 24);
            label7.TabIndex = 29;
            label7.Text = "Total Amout";
            // 
            // TotalAmount
            // 
            TotalAmount.AutoSize = true;
            TotalAmount.ForeColor = Color.FromArgb(81, 191, 164);
            TotalAmount.Location = new Point(908, 707);
            TotalAmount.Name = "TotalAmount";
            TotalAmount.Size = new Size(32, 24);
            TotalAmount.TabIndex = 29;
            TotalAmount.Text = "Rs";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(81, 191, 164);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(433, 700);
            button2.Name = "button2";
            button2.Size = new Size(165, 38);
            button2.TabIndex = 35;
            button2.Text = "Insert Order";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(81, 191, 164);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(604, 700);
            button1.Name = "button1";
            button1.Size = new Size(165, 38);
            button1.TabIndex = 36;
            button1.Text = "View Orders";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(81, 191, 164);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(342, 700);
            button3.Name = "button3";
            button3.Size = new Size(85, 38);
            button3.TabIndex = 37;
            button3.Text = "Home";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // ManageOrders
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1164, 752);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(OrderGV);
            Controls.Add(ProductsDataGV);
            Controls.Add(SearchCombo);
            Controls.Add(OrderDate);
            Controls.Add(QtyTb);
            Controls.Add(OrderIdTb);
            Controls.Add(CustomerNameTb);
            Controls.Add(CustomerIdTb);
            Controls.Add(label6);
            Controls.Add(label011);
            Controls.Add(TotalAmount);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(CustomersDataGV);
            Controls.Add(label8);
            Controls.Add(panel1);
            Font = new Font("Lato Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ManageOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageOrders";
            Load += ManageOrders_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)CustomersDataGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductsDataGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrderGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private DataGridView CustomersDataGV;
        private Label label8;
        private TextBox OrderIdTb;
        private TextBox CustomerIdTb;
        private Label label011;
        private Label label3;
        private DateTimePicker OrderDate;
        private Label label4;
        private DataGridView ProductsDataGV;
        private ComboBox SearchCombo;
        private Label label5;
        private TextBox CustomerNameTb;
        private TextBox QtyTb;
        private Label label6;
        private Button button4;
        private DataGridView OrderGV;
        private Label label7;
        private Label TotalAmount;
        private Button button2;
        private Button button1;
        private Button button3;
    }
}