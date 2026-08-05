namespace Project_Students
{
    partial class StudentsForm
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtID = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtPhone = new TextBox();
            label5 = new Label();
            txtYear = new TextBox();
            label6 = new Label();
            cboDept = new ComboBox();
            label7 = new Label();
            txtSearch = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(240, 244, 248);
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.FromArgb(26, 58, 110);
            dataGridView1.Location = new Point(625, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(729, 736);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 110);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(42, 63, 111);
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(112, 103);
            txtName.Name = "txtName";
            txtName.Size = new Size(385, 27);
            txtName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(34, 188);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 3;
            label2.Text = "ID:";
            // 
            // txtID
            // 
            txtID.BackColor = Color.FromArgb(42, 63, 111);
            txtID.ForeColor = Color.White;
            txtID.Location = new Point(112, 181);
            txtID.Name = "txtID";
            txtID.Size = new Size(170, 27);
            txtID.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(29, 272);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 5;
            label3.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(42, 63, 111);
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(112, 265);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(257, 27);
            txtEmail.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(21, 357);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 7;
            label4.Text = "Phone:";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.FromArgb(42, 63, 111);
            txtPhone.ForeColor = Color.White;
            txtPhone.Location = new Point(112, 350);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(170, 27);
            txtPhone.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(21, 429);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 9;
            label5.Text = "Year:";
            // 
            // txtYear
            // 
            txtYear.BackColor = Color.FromArgb(42, 63, 111);
            txtYear.ForeColor = Color.White;
            txtYear.Location = new Point(112, 422);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(114, 27);
            txtYear.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(29, 526);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 11;
            label6.Text = "Dept:";
            // 
            // cboDept
            // 
            cboDept.BackColor = Color.FromArgb(42, 63, 111);
            cboDept.ForeColor = Color.White;
            cboDept.FormattingEnabled = true;
            cboDept.Location = new Point(112, 518);
            cboDept.Name = "cboDept";
            cboDept.Size = new Size(151, 28);
            cboDept.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.2F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(21, 609);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 13;
            label7.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(42, 63, 111);
            txtSearch.ForeColor = Color.White;
            txtSearch.Location = new Point(112, 602);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(170, 27);
            txtSearch.TabIndex = 14;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(26, 58, 110);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(34, 682);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 57, 43);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(258, 682);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(96, 165, 250);
            label8.Location = new Point(176, 27);
            label8.Name = "label8";
            label8.Size = new Size(256, 31);
            label8.TabIndex = 17;
            label8.Text = "Students Management";
            // 
            // StudentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 45, 78);
            ClientSize = new Size(1378, 741);
            Controls.Add(label8);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtSearch);
            Controls.Add(label7);
            Controls.Add(cboDept);
            Controls.Add(label6);
            Controls.Add(txtYear);
            Controls.Add(label5);
            Controls.Add(txtPhone);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            ForeColor = Color.White;
            Name = "StudentsForm";
            Text = "StudentsForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtName;
        private Label label2;
        private TextBox txtID;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtPhone;
        private Label label5;
        private TextBox txtYear;
        private Label label6;
        private ComboBox cboDept;
        private Label label7;
        private TextBox txtSearch;
        private Button btnAdd;
        private Button btnDelete;
        private Label label8;
    }
}