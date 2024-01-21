namespace InventoryManagementSystem
{
    partial class UserManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagement));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            UnameTb = new TextBox();
            label011 = new Label();
            UfullNameTb = new TextBox();
            label3 = new Label();
            UpasswardTb = new TextBox();
            label4 = new Label();
            UphoneTb = new TextBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            userDataGV = new DataGridView();
            label6 = new Label();
            button6 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userDataGV).BeginInit();
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
            panel1.TabIndex = 0;
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
            label1.Location = new Point(482, 61);
            label1.Name = "label1";
            label1.Size = new Size(185, 33);
            label1.TabIndex = 0;
            label1.Text = "Manage Users";
            // 
            // UnameTb
            // 
            UnameTb.BorderStyle = BorderStyle.FixedSingle;
            UnameTb.Location = new Point(58, 212);
            UnameTb.Name = "UnameTb";
            UnameTb.Size = new Size(238, 31);
            UnameTb.TabIndex = 1;
            // 
            // label011
            // 
            label011.AutoSize = true;
            label011.Location = new Point(58, 185);
            label011.Name = "label011";
            label011.Size = new Size(101, 24);
            label011.TabIndex = 2;
            label011.Text = "Username";
            // 
            // UfullNameTb
            // 
            UfullNameTb.BorderStyle = BorderStyle.FixedSingle;
            UfullNameTb.Location = new Point(58, 283);
            UfullNameTb.Name = "UfullNameTb";
            UfullNameTb.Size = new Size(238, 31);
            UfullNameTb.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 256);
            label3.Name = "label3";
            label3.Size = new Size(99, 24);
            label3.TabIndex = 2;
            label3.Text = "Full Name";
            // 
            // UpasswardTb
            // 
            UpasswardTb.BorderStyle = BorderStyle.FixedSingle;
            UpasswardTb.Location = new Point(58, 354);
            UpasswardTb.Name = "UpasswardTb";
            UpasswardTb.Size = new Size(238, 31);
            UpasswardTb.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 327);
            label4.Name = "label4";
            label4.Size = new Size(94, 24);
            label4.TabIndex = 2;
            label4.Text = "Passward";
            // 
            // UphoneTb
            // 
            UphoneTb.BorderStyle = BorderStyle.FixedSingle;
            UphoneTb.Location = new Point(58, 425);
            UphoneTb.Name = "UphoneTb";
            UphoneTb.Size = new Size(238, 31);
            UphoneTb.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 398);
            label5.Name = "label5";
            label5.Size = new Size(102, 24);
            label5.TabIndex = 2;
            label5.Text = "Telephone";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(81, 191, 164);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(44, 486);
            button1.Name = "button1";
            button1.Size = new Size(85, 38);
            button1.TabIndex = 3;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(81, 191, 164);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(135, 486);
            button2.Name = "button2";
            button2.Size = new Size(85, 38);
            button2.TabIndex = 3;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(81, 191, 164);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(226, 486);
            button3.Name = "button3";
            button3.Size = new Size(85, 38);
            button3.TabIndex = 3;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(81, 191, 164);
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(135, 540);
            button4.Name = "button4";
            button4.Size = new Size(85, 38);
            button4.TabIndex = 3;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // userDataGV
            // 
            userDataGV.AllowUserToAddRows = false;
            userDataGV.AllowUserToDeleteRows = false;
            userDataGV.AllowUserToResizeColumns = false;
            userDataGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userDataGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            userDataGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            userDataGV.BackgroundColor = Color.White;
            userDataGV.BorderStyle = BorderStyle.None;
            userDataGV.CellBorderStyle = DataGridViewCellBorderStyle.None;
            userDataGV.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            userDataGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(81, 191, 164);
            dataGridViewCellStyle2.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(81, 191, 164);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            userDataGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            userDataGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            userDataGV.DefaultCellStyle = dataGridViewCellStyle3;
            userDataGV.EditMode = DataGridViewEditMode.EditProgrammatically;
            userDataGV.EnableHeadersVisualStyles = false;
            userDataGV.GridColor = Color.White;
            userDataGV.Location = new Point(364, 212);
            userDataGV.MultiSelect = false;
            userDataGV.Name = "userDataGV";
            userDataGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            userDataGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            userDataGV.RowHeadersVisible = false;
            userDataGV.RowHeadersWidth = 51;
            userDataGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userDataGV.ShowCellErrors = false;
            userDataGV.ShowCellToolTips = false;
            userDataGV.ShowEditingIcon = false;
            userDataGV.ShowRowErrors = false;
            userDataGV.Size = new Size(751, 500);
            userDataGV.TabIndex = 4;
            userDataGV.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lato", 16.1999989F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(677, 162);
            label6.Name = "label6";
            label6.Size = new Size(120, 33);
            label6.TabIndex = 0;
            label6.Text = "User List";
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(81, 191, 164);
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(1057, 137);
            button6.Name = "button6";
            button6.Size = new Size(95, 38);
            button6.TabIndex = 20;
            button6.Text = "Refresh";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1164, 752);
            Controls.Add(button6);
            Controls.Add(userDataGV);
            Controls.Add(button4);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(UphoneTb);
            Controls.Add(label4);
            Controls.Add(UpasswardTb);
            Controls.Add(label3);
            Controls.Add(UfullNameTb);
            Controls.Add(label011);
            Controls.Add(UnameTb);
            Controls.Add(panel1);
            Font = new Font("Lato Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserManagement";
            Load += UserManagement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)userDataGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox UnameTb;
        private Label label011;
        private TextBox UfullNameTb;
        private Label label3;
        private TextBox UpasswardTb;
        private Label label4;
        private TextBox UphoneTb;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView userDataGV;
        private PictureBox pictureBox2;
        private Label label6;
        private Button button6;
    }
}