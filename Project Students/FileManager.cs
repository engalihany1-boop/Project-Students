using System;
using System.Collections.Generic;
using System.Text;

using System;
using System.IO;

namespace Project_Students
{
    public static class FileManager
    {
        private static string StudentsFile = "students.csv";
        private static string CoursesFile = "courses.csv";
        private static string EnrollmentsFile = "enrollments.csv";

        public static void SaveStudents()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(StudentsFile))
                {
                    sw.WriteLine("Name,ID,Email,Phone,Year,Dept,Status,GPA");
                    for (int i = 0; i < MainForm.SCount; i++)
                        sw.WriteLine(MainForm.Students[i].ToCSV());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public static void SaveCourses()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(CoursesFile))
                {
                    sw.WriteLine("CourseID,Name,Hours,Dept,Semester");
                    for (int i = 0; i < MainForm.CCount; i++)
                        sw.WriteLine(MainForm.Courses[i].ToCSV());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public static void SaveEnrollments()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(EnrollmentsFile))
                {
                    sw.WriteLine("StudentID,CourseID,Score,Grade,Semester");
                    for (int i = 0; i < MainForm.ECount; i++)
                        sw.WriteLine(MainForm.Enrollments[i].ToCSV());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public static void LoadStudents()
        {
            if (!File.Exists(StudentsFile)) return;
            try
            {
                using (StreamReader sr = new StreamReader(StudentsFile))
                {
                    sr.ReadLine();
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] p = line.Split(',');
                        if (p.Length < 6) continue;
                        Department dept = (Department)Enum.Parse(typeof(Department), p[5]);
                        var s = new Student(p[0], p[1], p[2], p[3], int.Parse(p[4]), dept);
                        MainForm.Students[MainForm.SCount++] = s;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public static void LoadCourses()
        {
            if (!File.Exists(CoursesFile)) return;
            try
            {
                using (StreamReader sr = new StreamReader(CoursesFile))
                {
                    sr.ReadLine();
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] p = line.Split(',');
                        if (p.Length < 5) continue;
                        Department dept = (Department)Enum.Parse(typeof(Department), p[3]);
                        Semester sem = (Semester)Enum.Parse(typeof(Semester), p[4]);
                        var c = new Course(p[0], p[1], int.Parse(p[2]), dept, sem);
                        MainForm.Courses[MainForm.CCount++] = c;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public static void LoadEnrollments()
        {
            if (!File.Exists(EnrollmentsFile)) return;
            try
            {
                using (StreamReader sr = new StreamReader(EnrollmentsFile))
                {
                    sr.ReadLine();
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] p = line.Split(',');
                        if (p.Length < 5) continue;
                        Student st = FindStudent(p[0]);
                        Course co = FindCourse(p[1]);
                        if (st == null || co == null) continue;
                        Semester sem = (Semester)Enum.Parse(typeof(Semester), p[4]);
                        var e = new Enrollment(st, co, double.Parse(p[2]), sem);
                        st.Enroll(e);
                        st.CalcGPA();
                        MainForm.Enrollments[MainForm.ECount++] = e;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private static Student FindStudent(string id)
        {
            for (int i = 0; i < MainForm.SCount; i++)
                if (MainForm.Students[i].GetID() == id) return MainForm.Students[i];
            return null;
        }

        private static Course FindCourse(string id)
        {
            for (int i = 0; i < MainForm.CCount; i++)
                if (MainForm.Courses[i].GetCourseID() == id) return MainForm.Courses[i];
            return null;
        }
    }
}