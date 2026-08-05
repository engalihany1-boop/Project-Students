using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace Project_Students
{
    public class Student : Person
    {
        private int Year;
        private Department Dept;
        private StudentStatus Status;
        private double GPA;
        private Enrollment[] Enrollments;
        private int EnrollCount;

        


        public Student(string name, string id,
            string email, string phone,
            int year, Department dept)
            : base(name, id, email, phone)
        {
            Year = year;
            Dept = dept;
            Status = StudentStatus.Active;
            Enrollments = new Enrollment[20];
            EnrollCount = 0;
        }
        

        public int GetYear() => Year;
        public Department GetDept() => Dept;
        public StudentStatus GetStatus() => Status;
        public double GetGPA() => GPA;

        public void Enroll(Enrollment e)
        {
            if (EnrollCount < 20)
                Enrollments[EnrollCount++] = e;
        }

        public void CalcGPA()
        {
            if (EnrollCount == 0) { GPA = 0; return; }
            double totalGPA = 0;
            for (int i = 0; i < EnrollCount; i++)
            {
                double score = Enrollments[i].GetScore();
                if (score >= 95) totalGPA  += 4.0;
                else if (score >= 85)  totalGPA += 3.7;
                else if (score >= 75)  totalGPA += 3.3;
                else if (score >= 65)  totalGPA += 3.0;
                else if (score >= 55) totalGPA += 2.0;
                else if (score >= 50) totalGPA += 1.0;
                else totalGPA += 0.0;
            }
            GPA = Math.Round(totalGPA / EnrollCount, 2);
        }

        public override string GetInfo() =>
            Name + " | " + ID + " | Year:" + Year + " | " + Dept + " | GPA:" + GPA;

        public string ToCSV() =>
            Name + "," + ID + "," + Email + "," + Phone + "," + Year + "," + Dept + "," + Status + "," + GPA;
    }
}