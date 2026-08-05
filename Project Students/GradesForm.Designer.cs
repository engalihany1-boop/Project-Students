namespace Project_Students
{
    partial class GradesForm
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
            label1 = new Label();
            cboStudent = new ComboBox();
            label2 = new Label();
            cboCourse = new ComboBox();
            label3 = new Label();
            cboSemester = new ComboBox();
            label4 = new Label();
            txtScore = new TextBox();
            lblGrade = new Label();
            lblGPA = new Label();
            btnSaveGrade = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(6, 82);
            label1.Name = "label1";
            label1.Size = new Size(80, 23);
            label1.TabIndex = 0;
            label1.Text = "Students:";
            // 
            // cboStudent
            // 
            cboStudent.BackColor = Color.FromArgb(42, 63, 111);
            cboStudent.ForeColor = Color.White;
            cboStudent.FormattingEnabled = true;
            cboStudent.Location = new Point(127, 82);
            cboStudent.Name = "cboStudent";
            cboStudent.Size = new Size(298, 31);
            cboStudent.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 170);
            label2.Name = "label2";
            label2.Size = new Size(67, 23);
            label2.TabIndex = 2;
            label2.Text = "Course:";
            // 
            // cboCourse
            // 
            cboCourse.BackColor = Color.FromArgb(42, 63, 111);
            cboCourse.ForeColor = Color.White;
            cboCourse.FormattingEnabled = true;
            cboCourse.Location = new Point(127, 170);
            cboCourse.Name = "cboCourse";
            cboCourse.Size = new Size(212, 31);
            cboCourse.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(6, 254);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 4;
            label3.Text = "Semester:";
            // 
            // cboSemester
            // 
            cboSemester.BackColor = Color.FromArgb(42, 63, 111);
            cboSemester.ForeColor = Color.White;
            cboSemester.FormattingEnabled = true;
            cboSemester.Location = new Point(127, 246);
            cboSemester.Name = "cboSemester";
            cboSemester.Size = new Size(298, 31);
            cboSemester.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(20, 364);
            label4.Name = "label4";
            label4.Size = new Size(56, 23);
            label4.TabIndex = 6;
            label4.Text = "Score:";
            // 
            // txtScore
            // 
            txtScore.BackColor = Color.FromArgb(42, 63, 111);
            txtScore.ForeColor = Color.White;
            txtScore.Location = new Point(127, 357);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(178, 30);
            txtScore.TabIndex = 7;
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.ForeColor = Color.White;
            lblGrade.Location = new Point(20, 442);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(60, 23);
            lblGrade.TabIndex = 8;
            lblGrade.Text = "Grade:";
            // 
            // lblGPA
            // 
            lblGPA.AutoSize = true;
            lblGPA.ForeColor = Color.White;
            lblGPA.Location = new Point(20, 529);
            lblGPA.Name = "lblGPA";
            lblGPA.Size = new Size(46, 23);
            lblGPA.TabIndex = 9;
            lblGPA.Text = "GPA:";
            // 
            // btnSaveGrade
            // 
            btnSaveGrade.Location = new Point(596, 637);
            btnSaveGrade.Name = "btnSaveGrade";
            btnSaveGrade.Size = new Size(165, 33);
            btnSaveGrade.TabIndex = 10;
            btnSaveGrade.Text = "Save Grade";
            btnSaveGrade.UseVisualStyleBackColor = true;
            btnSaveGrade.Click += btnSaveGrade_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 63, 111);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSaveGrade);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtScore);
            panel1.Controls.Add(lblGPA);
            panel1.Controls.Add(cboSemester);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cboCourse);
            panel1.Controls.Add(lblGrade);
            panel1.Controls.Add(cboStudent);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 741);
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint;
            // 
            // GradesForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 248);
            ClientSize = new Size(1578, 846);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(26, 58, 110);
            Name = "GradesForm";
            Text = "GradesForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ComboBox cboStudent;
        private Label label2;
        private ComboBox cboCourse;
        private Label label3;
        private ComboBox cboSemester;
        private Label label4;
        private TextBox txtScore;
        private Label lblGrade;
        private Label lblGPA;
        private Button btnSaveGrade;
        private Panel panel1;
    }
}