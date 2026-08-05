using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Students
{
    public class Teacher : Person
    {
        private string Title;
        private Department Dept;
        private Course[] Courses;
        private int CourseCount;

        public Teacher(string name, string id,
            string email, string phone,
            string title, Department dept)
            : base(name, id, email, phone)
        {
            Title = title;
            Dept = dept;
            Courses = new Course[10];
            CourseCount = 0;
        }

        public string GetTitle() => Title;
        public Department GetDept() => Dept;

        public void AssignCourse(Course c)
        {
            if (CourseCount < 10)
                Courses[CourseCount++] = c;
        }

        public override string GetInfo() =>
            Title + " " + Name + " | " + ID + " | " + Dept;

        public string ToCSV() =>
            Name + "," + ID + "," + Email + "," + Phone + "," + Title + "," + Dept;
    }
}
