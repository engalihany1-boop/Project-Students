using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Students
{
    public class Course
    {
        private string CourseID;
        private string CourseName;
        private int CreditHours;
        private Department Dept;
        private Semester Sem;

        public Course(string cid, string cname, int hours, Department dept, Semester sem)
        {
            CourseID = cid;
            CourseName = cname;
            CreditHours = hours;
            Dept = dept;
            Sem = sem;
        }

        public string GetCourseID() { return CourseID; } //=>CourseID;
        public string GetCourseName() { return CourseName; } //=>CourseName;
        public int GetCreditHours()  { return CreditHours ;}
        public Department GetDept() { return Dept; }
        public Semester GetSem() => Sem;

        public string GetInfo() =>
            CourseID + " | " + CourseName + " | " + CreditHours + "hr | " + Dept;

        public string ToCSV() =>
            CourseID + "," + CourseName + "," + CreditHours + "," + Dept + "," + Sem;

        public override string ToString() => CourseName;
    }
}
