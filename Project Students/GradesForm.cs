using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System;
using System.Windows.Forms;

namespace Project_Students
{
    public partial class GradesForm : Form
    {
        public GradesForm()
        {
            InitializeComponent();
            for (int i = 0; i < MainForm.SCount; i++)
                cboStudent.Items.Add(MainForm.Students[i]);
            for (int i = 0; i < MainForm.CCount; i++)
                cboCourse.Items.Add(MainForm.Courses[i]);
            cboSemester.Items.Add("First");
            cboSemester.Items.Add("Second");
            cboSemester.Items.Add("Summer");
            cboSemester.SelectedIndex = 0;
        }

        private void btnSaveGrade_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboStudent.SelectedItem == null ||
                    cboCourse.SelectedItem == null)
                    throw new Exception("Select student and course!");

                double score = double.Parse(txtScore.Text);
                if (score < 0 || score > 100)
                    throw new Exception("Score must be between 0 and 100!");

                var student = (Student)cboStudent.SelectedItem;
                var course = (Course)cboCourse.SelectedItem;
                var sem = (Semester)cboSemester.SelectedIndex;

                var enrollment = new Enrollment(student, course, score, sem);
                student.Enroll(enrollment);
                student.CalcGPA();

                MainForm.Enrollments[MainForm.ECount++] = enrollment;
                FileManager.SaveEnrollments();

                lblGrade.Text = "Grade: " + enrollment.GetLetterGrade();
                lblGPA.Text = "GPA: " + student.GetGPA();
                MessageBox.Show("Grade saved!", "Success");
            }
            catch (FormatException)
            {
                MessageBox.Show("Score must be a number!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
