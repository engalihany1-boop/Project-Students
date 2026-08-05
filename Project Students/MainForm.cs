using System;
using System.Windows.Forms;


using System;
using System.Windows.Forms;

namespace Project_Students
{
    public partial class MainForm : Form
    {
        public static Student[] Students = new Student[100];
        public static Teacher[] Teachers = new Teacher[50];
        public static Course[] Courses = new Course[50];
        public static Enrollment[] Enrollments = new Enrollment[500];
        public static int SCount, TCount, CCount, ECount;

        public MainForm()
        {
            InitializeComponent();
            FileManager.LoadStudents();
            FileManager.LoadCourses();
            FileManager.LoadEnrollments();

            if (CCount == 0)
            {
                Courses[CCount++] = new Course("CS101", "OOP", 3, Department.CS, Semester.First);
                Courses[CCount++] = new Course("CS102", "Data Structures", 3, Department.CS, Semester.Second);
                Courses[CCount++] = new Course("CS103", "Algorithms", 3, Department.CS, Semester.First);
                Courses[CCount++] = new Course("IT101", "Networks", 3, Department.IT, Semester.First);
                Courses[CCount++] = new Course("AI101", "Machine Learning", 3, Department.AI, Semester.Second);
                FileManager.SaveCourses();
            }
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            new StudentsForm().ShowDialog();
        }

        private void btnGrades_Click(object sender, EventArgs e)
        {
            new GradesForm().ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileManager.SaveStudents();
            FileManager.SaveCourses();
            FileManager.SaveEnrollments();
        }
    }
}
