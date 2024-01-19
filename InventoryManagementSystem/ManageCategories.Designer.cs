namespace InventoryManagementSystem
{
    partial class ManageCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCategories));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            categoryDataGV = new DataGridView();
            label6 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            categoryNameTb = new TextBox();
            label4 = new Label();
            CategoryIdTb = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryDataGV).BeginInit();
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
            panel1.TabIndex = 5;
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
            label2.Location = new Point(364, 25);
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
            label1.Location = new Point(463, 61);
            label1.Name = "label1";
            label1.Size = new Size(245, 33);
            label1.TabIndex = 0;
            label1.Text = "Manage Categories";
            // 
            // categoryDataGV
            // 
            dataGridViewCellStyle1.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            categoryDataGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            categoryDataGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            categoryDataGV.BackgroundColor = Color.White;
            categoryDataGV.BorderStyle = BorderStyle.None;
            categoryDataGV.CellBorderStyle = DataGridViewCellBorderStyle.None;
            categoryDataGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(81, 191, 164);
            dataGridViewCellStyle2.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(81, 191, 164);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            categoryDataGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            categoryDataGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            categoryDataGV.DefaultCellStyle = dataGridViewCellStyle3;
            categoryDataGV.EnableHeadersVisualStyles = false;
            categoryDataGV.GridColor = Color.White;
            categoryDataGV.Location = new Point(364, 232);
            categoryDataGV.MultiSelect = false;
            categoryDataGV.Name = "categoryDataGV";
            categoryDataGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            categoryDataGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            categoryDataGV.RowHeadersVisible = false;
            categoryDataGV.RowHeadersWidth = 51;
            categoryDataGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            categoryDataGV.ShowCellErrors = false;
            categoryDataGV.ShowCellToolTips = false;
            categoryDataGV.ShowEditingIcon = false;
            categoryDataGV.ShowRowErrors = false;
            categoryDataGV.Size = new Size(751, 500);
            categoryDataGV.TabIndex = 7;
            categoryDataGV.CellContentClick += categoryDataGV_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lato", 16.1999989F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(643, 181);
            label6.Name = "label6";
            label6.Size = new Size(192, 33);
            label6.TabIndex = 6;
            label6.Text = "Categories List";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(81, 191, 164);
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(122, 441);
            button4.Name = "button4";
            button4.Size = new Size(85, 38);
            button4.TabIndex = 12;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(81, 191, 164);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(213, 387);
            button3.Name = "button3";
            button3.Size = new Size(85, 38);
            button3.TabIndex = 13;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(81, 191, 164);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(122, 387);
            button2.Name = "button2";
            button2.Size = new Size(85, 38);
            button2.TabIndex = 14;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(81, 191, 164);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(31, 387);
            button1.Name = "button1";
            button1.Size = new Size(85, 38);
            button1.TabIndex = 15;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 277);
            label5.Name = "label5";
            label5.Size = new Size(147, 24);
            label5.TabIndex = 10;
            label5.Text = "Category Name";
            // 
            // categoryNameTb
            // 
            categoryNameTb.BorderStyle = BorderStyle.FixedSingle;
            categoryNameTb.Location = new Point(46, 304);
            categoryNameTb.Name = "categoryNameTb";
            categoryNameTb.Size = new Size(238, 31);
            categoryNameTb.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 206);
            label4.Name = "label4";
            label4.Size = new Size(115, 24);
            label4.TabIndex = 11;
            label4.Text = "Category ID";
            // 
            // CategoryIdTb
            // 
            CategoryIdTb.BorderStyle = BorderStyle.FixedSingle;
            CategoryIdTb.Location = new Point(46, 233);
            CategoryIdTb.Name = "CategoryIdTb";
            CategoryIdTb.Size = new Size(238, 31);
            CategoryIdTb.TabIndex = 9;
            // 
            // ManageCategories
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1164, 752);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(categoryNameTb);
            Controls.Add(label4);
            Controls.Add(CategoryIdTb);
            Controls.Add(panel1);
            Controls.Add(categoryDataGV);
            Controls.Add(label6);
            Font = new Font("Lato Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ManageCategories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageCategories";
            Load += ManageCategories_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryDataGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private DataGridView categoryDataGV;
        private Label label6;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label5;
        private TextBox categoryNameTb;
        private Label label4;
        private TextBox CategoryIdTb;
    }
}