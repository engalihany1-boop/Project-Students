namespace Project_Students
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStudents = new Button();
            btnGrades = new Button();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnStudents
            // 
            btnStudents.BackColor = Color.Teal;
            btnStudents.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudents.ForeColor = SystemColors.ControlLightLight;
            btnStudents.Location = new Point(453, 376);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(401, 125);
            btnStudents.TabIndex = 0;
            btnStudents.Text = "Students Management";
            btnStudents.UseVisualStyleBackColor = false;
            btnStudents.Click += btnStudents_Click;
            // 
            // btnGrades
            // 
            btnGrades.BackColor = Color.Teal;
            btnGrades.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGrades.ForeColor = SystemColors.ControlLightLight;
            btnGrades.Location = new Point(914, 376);
            btnGrades.Name = "btnGrades";
            btnGrades.Size = new Size(401, 125);
            btnGrades.TabIndex = 1;
            btnGrades.Text = "Grades Management";
            btnGrades.UseVisualStyleBackColor = false;
            btnGrades.Click += btnGrades_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 58, 110);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 732);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(90, 290);
            label1.Name = "label1";
            label1.Size = new Size(208, 28);
            label1.TabIndex = 3;
            label1.Text = "Mansoura University";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2026_04_29_at_2_01_48_PM;
            pictureBox1.Location = new Point(0, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(392, 259);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(35, 358);
            label2.Name = "label2";
            label2.Size = new Size(303, 20);
            label2.TabIndex = 3;
            label2.Text = "Faculty Of Computer & Infomation Sciences";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightBlue;
            label3.Location = new Point(12, 408);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 4;
            label3.Text = "Spring 2026";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(26, 58, 110);
            label4.Location = new Point(647, 59);
            label4.Name = "label4";
            label4.Size = new Size(405, 38);
            label4.TabIndex = 5;
            label4.Text = "Student Management System";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1373, 734);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(btnGrades);
            Controls.Add(btnStudents);
            Name = "MainForm";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStudents;
        private Button btnGrades;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
