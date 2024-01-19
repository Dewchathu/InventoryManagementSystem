namespace InventoryManagementSystem
{
    partial class ManageProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProducts));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            ProductQtyTb = new TextBox();
            ProductNameTb = new TextBox();
            label3 = new Label();
            ProductIdTb = new TextBox();
            label011 = new Label();
            label5 = new Label();
            ProductPriceTb = new TextBox();
            DescriptionTb = new TextBox();
            label6 = new Label();
            cateCombo = new ComboBox();
            label7 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ProductDataGV = new DataGridView();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductDataGV).BeginInit();
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
            panel1.TabIndex = 2;
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
            label1.Location = new Point(446, 63);
            label1.Name = "label1";
            label1.Size = new Size(224, 33);
            label1.TabIndex = 0;
            label1.Text = "Manage Products";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 324);
            label4.Name = "label4";
            label4.Size = new Size(117, 24);
            label4.TabIndex = 15;
            label4.Text = "Product Qty";
            // 
            // ProductQtyTb
            // 
            ProductQtyTb.BorderStyle = BorderStyle.FixedSingle;
            ProductQtyTb.Location = new Point(40, 351);
            ProductQtyTb.Name = "ProductQtyTb";
            ProductQtyTb.Size = new Size(238, 31);
            ProductQtyTb.TabIndex = 12;
            // 
            // ProductNameTb
            // 
            ProductNameTb.BorderStyle = BorderStyle.FixedSingle;
            ProductNameTb.Location = new Point(40, 280);
            ProductNameTb.Name = "ProductNameTb";
            ProductNameTb.Size = new Size(238, 31);
            ProductNameTb.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 253);
            label3.Name = "label3";
            label3.Size = new Size(137, 24);
            label3.TabIndex = 16;
            label3.Text = "Product Name";
            // 
            // ProductIdTb
            // 
            ProductIdTb.BorderStyle = BorderStyle.FixedSingle;
            ProductIdTb.Location = new Point(40, 209);
            ProductIdTb.Name = "ProductIdTb";
            ProductIdTb.Size = new Size(238, 31);
            ProductIdTb.TabIndex = 14;
            // 
            // label011
            // 
            label011.AutoSize = true;
            label011.Location = new Point(40, 182);
            label011.Name = "label011";
            label011.Size = new Size(101, 24);
            label011.TabIndex = 17;
            label011.Text = "Product Id";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 399);
            label5.Name = "label5";
            label5.Size = new Size(129, 24);
            label5.TabIndex = 16;
            label5.Text = "Product Price";
            // 
            // ProductPriceTb
            // 
            ProductPriceTb.BorderStyle = BorderStyle.FixedSingle;
            ProductPriceTb.Location = new Point(40, 426);
            ProductPriceTb.Name = "ProductPriceTb";
            ProductPriceTb.Size = new Size(238, 31);
            ProductPriceTb.TabIndex = 13;
            // 
            // DescriptionTb
            // 
            DescriptionTb.BorderStyle = BorderStyle.FixedSingle;
            DescriptionTb.Location = new Point(40, 497);
            DescriptionTb.Name = "DescriptionTb";
            DescriptionTb.Size = new Size(238, 31);
            DescriptionTb.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 470);
            label6.Name = "label6";
            label6.Size = new Size(113, 24);
            label6.TabIndex = 15;
            label6.Text = "Description";
            // 
            // cateCombo
            // 
            cateCombo.FormattingEnabled = true;
            cateCombo.Location = new Point(40, 578);
            cateCombo.Name = "cateCombo";
            cateCombo.Size = new Size(236, 32);
            cateCombo.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 548);
            label7.Name = "label7";
            label7.Size = new Size(163, 24);
            label7.TabIndex = 15;
            label7.Text = "Product Category";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(81, 191, 164);
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(120, 692);
            button4.Name = "button4";
            button4.Size = new Size(85, 38);
            button4.TabIndex = 19;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(81, 191, 164);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(211, 638);
            button3.Name = "button3";
            button3.Size = new Size(85, 38);
            button3.TabIndex = 20;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(81, 191, 164);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(120, 638);
            button2.Name = "button2";
            button2.Size = new Size(85, 38);
            button2.TabIndex = 21;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(81, 191, 164);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(29, 638);
            button1.Name = "button1";
            button1.Size = new Size(85, 38);
            button1.TabIndex = 22;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ProductDataGV
            // 
            dataGridViewCellStyle1.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductDataGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ProductDataGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductDataGV.BackgroundColor = Color.White;
            ProductDataGV.BorderStyle = BorderStyle.None;
            ProductDataGV.CellBorderStyle = DataGridViewCellBorderStyle.None;
            ProductDataGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(81, 191, 164);
            dataGridViewCellStyle2.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(81, 191, 164);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            ProductDataGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ProductDataGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ProductDataGV.DefaultCellStyle = dataGridViewCellStyle3;
            ProductDataGV.EnableHeadersVisualStyles = false;
            ProductDataGV.GridColor = Color.White;
            ProductDataGV.Location = new Point(354, 223);
            ProductDataGV.MultiSelect = false;
            ProductDataGV.Name = "ProductDataGV";
            ProductDataGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            ProductDataGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            ProductDataGV.RowHeadersVisible = false;
            ProductDataGV.RowHeadersWidth = 51;
            ProductDataGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductDataGV.ShowCellErrors = false;
            ProductDataGV.ShowCellToolTips = false;
            ProductDataGV.ShowEditingIcon = false;
            ProductDataGV.ShowRowErrors = false;
            ProductDataGV.Size = new Size(751, 404);
            ProductDataGV.TabIndex = 24;
            ProductDataGV.CellContentClick += ProductDataGV_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lato", 16.1999989F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(639, 173);
            label8.Name = "label8";
            label8.Size = new Size(171, 33);
            label8.TabIndex = 23;
            label8.Text = "Products List";
            // 
            // ManageProducts
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1164, 752);
            Controls.Add(ProductDataGV);
            Controls.Add(label8);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cateCombo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(DescriptionTb);
            Controls.Add(ProductQtyTb);
            Controls.Add(ProductIdTb);
            Controls.Add(ProductPriceTb);
            Controls.Add(ProductNameTb);
            Controls.Add(label011);
            Controls.Add(label5);
            Controls.Add(label3);
            Font = new Font("Lato Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageProducts";
            Load += ManageProducts_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductDataGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox ProductQtyTb;
        private TextBox ProductNameTb;
        private Label label3;
        private TextBox ProductIdTb;
        private Label label011;
        private Label label5;
        private TextBox ProductPriceTb;
        private TextBox DescriptionTb;
        private Label label6;
        private ComboBox cateCombo;
        private Label label7;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView ProductDataGV;
        private Label label8;
    }
}