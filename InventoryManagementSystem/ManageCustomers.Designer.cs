namespace InventoryManagementSystem
{
    partial class ManageCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCustomers));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            CustomerPhoneTb = new TextBox();
            label3 = new Label();
            CustomerNameTb = new TextBox();
            label011 = new Label();
            CustomerIdTb = new TextBox();
            CustomerDataGV = new DataGridView();
            label6 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            label9 = new Label();
            CountLb = new Label();
            panel3 = new Panel();
            label10 = new Label();
            AmountLb = new Label();
            panel4 = new Panel();
            label11 = new Label();
            DateLb = new Label();
            button5 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomerDataGV).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
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
            panel1.TabIndex = 1;
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
            label1.Location = new Point(442, 63);
            label1.Name = "label1";
            label1.Size = new Size(246, 33);
            label1.TabIndex = 0;
            label1.Text = "Manage Customers";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 333);
            label4.Name = "label4";
            label4.Size = new Size(157, 24);
            label4.TabIndex = 9;
            label4.Text = "Customer Phone";
            // 
            // CustomerPhoneTb
            // 
            CustomerPhoneTb.BorderStyle = BorderStyle.FixedSingle;
            CustomerPhoneTb.Location = new Point(51, 360);
            CustomerPhoneTb.Name = "CustomerPhoneTb";
            CustomerPhoneTb.Size = new Size(238, 31);
            CustomerPhoneTb.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 262);
            label3.Name = "label3";
            label3.Size = new Size(154, 24);
            label3.TabIndex = 10;
            label3.Text = "Customer Name";
            // 
            // CustomerNameTb
            // 
            CustomerNameTb.BorderStyle = BorderStyle.FixedSingle;
            CustomerNameTb.Location = new Point(51, 289);
            CustomerNameTb.Name = "CustomerNameTb";
            CustomerNameTb.Size = new Size(238, 31);
            CustomerNameTb.TabIndex = 7;
            // 
            // label011
            // 
            label011.AutoSize = true;
            label011.Location = new Point(51, 191);
            label011.Name = "label011";
            label011.Size = new Size(118, 24);
            label011.TabIndex = 11;
            label011.Text = "Customer Id";
            // 
            // CustomerIdTb
            // 
            CustomerIdTb.BorderStyle = BorderStyle.FixedSingle;
            CustomerIdTb.Location = new Point(51, 218);
            CustomerIdTb.Name = "CustomerIdTb";
            CustomerIdTb.Size = new Size(238, 31);
            CustomerIdTb.TabIndex = 8;
            // 
            // CustomerDataGV
            // 
            CustomerDataGV.AllowUserToAddRows = false;
            CustomerDataGV.AllowUserToDeleteRows = false;
            CustomerDataGV.AllowUserToResizeColumns = false;
            CustomerDataGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomerDataGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            CustomerDataGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CustomerDataGV.BackgroundColor = Color.White;
            CustomerDataGV.BorderStyle = BorderStyle.None;
            CustomerDataGV.CellBorderStyle = DataGridViewCellBorderStyle.None;
            CustomerDataGV.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            CustomerDataGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(81, 191, 164);
            dataGridViewCellStyle2.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(81, 191, 164);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            CustomerDataGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            CustomerDataGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            CustomerDataGV.DefaultCellStyle = dataGridViewCellStyle3;
            CustomerDataGV.EditMode = DataGridViewEditMode.EditProgrammatically;
            CustomerDataGV.EnableHeadersVisualStyles = false;
            CustomerDataGV.GridColor = Color.White;
            CustomerDataGV.Location = new Point(350, 201);
            CustomerDataGV.MultiSelect = false;
            CustomerDataGV.Name = "CustomerDataGV";
            CustomerDataGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            CustomerDataGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            CustomerDataGV.RowHeadersVisible = false;
            CustomerDataGV.RowHeadersWidth = 51;
            CustomerDataGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CustomerDataGV.ShowCellErrors = false;
            CustomerDataGV.ShowCellToolTips = false;
            CustomerDataGV.ShowEditingIcon = false;
            CustomerDataGV.ShowRowErrors = false;
            CustomerDataGV.Size = new Size(751, 404);
            CustomerDataGV.TabIndex = 13;
            CustomerDataGV.CellContentClick += CustomerDataGV_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lato", 16.1999989F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(635, 151);
            label6.Name = "label6";
            label6.Size = new Size(181, 33);
            label6.TabIndex = 12;
            label6.Text = "Customer List";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(81, 191, 164);
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(125, 490);
            button4.Name = "button4";
            button4.Size = new Size(85, 38);
            button4.TabIndex = 14;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(81, 191, 164);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(216, 436);
            button3.Name = "button3";
            button3.Size = new Size(85, 38);
            button3.TabIndex = 15;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(81, 191, 164);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(125, 436);
            button2.Name = "button2";
            button2.Size = new Size(85, 38);
            button2.TabIndex = 16;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(81, 191, 164);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(34, 436);
            button1.Name = "button1";
            button1.Size = new Size(85, 38);
            button1.TabIndex = 17;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(81, 191, 164);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(CountLb);
            panel2.Location = new Point(100, 623);
            panel2.Name = "panel2";
            panel2.Size = new Size(237, 109);
            panel2.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Lato", 11F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(6, 7);
            label9.Name = "label9";
            label9.Size = new Size(127, 23);
            label9.TabIndex = 0;
            label9.Text = "Orders Count";
            // 
            // CountLb
            // 
            CountLb.AutoSize = true;
            CountLb.Font = new Font("Lato", 16.1999989F, FontStyle.Bold);
            CountLb.ForeColor = Color.White;
            CountLb.Location = new Point(68, 41);
            CountLb.Name = "CountLb";
            CountLb.Size = new Size(88, 33);
            CountLb.TabIndex = 0;
            CountLb.Text = "Count";
            CountLb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(81, 191, 164);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(AmountLb);
            panel3.Location = new Point(460, 623);
            panel3.Name = "panel3";
            panel3.Size = new Size(237, 109);
            panel3.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Lato", 11F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(7, 7);
            label10.Name = "label10";
            label10.Size = new Size(143, 23);
            label10.TabIndex = 0;
            label10.Text = "Orders Amoubt";
            // 
            // AmountLb
            // 
            AmountLb.AutoSize = true;
            AmountLb.Font = new Font("Lato", 16.1999989F, FontStyle.Bold);
            AmountLb.ForeColor = Color.White;
            AmountLb.Location = new Point(66, 41);
            AmountLb.Name = "AmountLb";
            AmountLb.Size = new Size(112, 33);
            AmountLb.TabIndex = 0;
            AmountLb.Text = "Amount";
            AmountLb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(81, 191, 164);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(DateLb);
            panel4.Location = new Point(820, 623);
            panel4.Name = "panel4";
            panel4.Size = new Size(237, 109);
            panel4.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Lato", 11F, FontStyle.Bold);
            label11.ForeColor = Color.White;
            label11.Location = new Point(7, 6);
            label11.Name = "label11";
            label11.Size = new Size(146, 23);
            label11.TabIndex = 0;
            label11.Text = "Last Order Date";
            // 
            // DateLb
            // 
            DateLb.AutoSize = true;
            DateLb.Font = new Font("Lato", 16.1999989F, FontStyle.Bold);
            DateLb.ForeColor = Color.White;
            DateLb.Location = new Point(80, 41);
            DateLb.Name = "DateLb";
            DateLb.Size = new Size(73, 33);
            DateLb.TabIndex = 0;
            DateLb.Text = "Date";
            DateLb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(81, 191, 164);
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(1048, 140);
            button5.Name = "button5";
            button5.Size = new Size(105, 38);
            button5.TabIndex = 19;
            button5.Text = "Refresh";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // ManageCustomers
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1164, 752);
            Controls.Add(button5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(CustomerDataGV);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(CustomerPhoneTb);
            Controls.Add(CustomerNameTb);
            Controls.Add(label3);
            Controls.Add(CustomerIdTb);
            Controls.Add(label011);
            Font = new Font("Lato Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ManageCustomers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageCustomers";
            Load += ManageCustomers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)CustomerDataGV).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox CustomerPhoneTb;
        private Label label3;
        private TextBox CustomerNameTb;
        private Label label011;
        private TextBox CustomerIdTb;
        private DataGridView CustomerDataGV;
        private Label label6;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private Label label9;
        private Label CountLb;
        private Panel panel3;
        private Label label10;
        private Label AmountLb;
        private Panel panel4;
        private Label label11;
        private Label DateLb;
        private Button button5;
    }
}