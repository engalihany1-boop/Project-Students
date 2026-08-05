using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Students
{
    public class Enrollment
    {
        private Student Student;
        private Course Course;
        private double Score;
        private Grade LetterGrade;
        private Semester Sem;

        public Enrollment(Student s, Course c,
            double score, Semester sem)
        {
            Student = s;
            Course = c;
            Score = score;
            Sem = sem;
            LetterGrade = CalcGrade();
        }

        public double GetScore() => Score;
        public Grade GetLetterGrade() => LetterGrade;
        public Course GetCourse() => Course;
        public Student GetStudent() => Student;

        public Grade CalcGrade()
        {
            if (Score >= 95) return Grade.A_Plus;
            if (Score >= 85) return Grade.A;
            if (Score >= 75) return Grade.B_Plus;
            if (Score >= 65) return Grade.B;
            if (Score >= 55) return Grade.C;
            if (Score >= 50) return Grade.D;
            return Grade.F;
        }

        public string ToCSV() =>
            Student.GetID() + "," + Course.GetCourseID() + "," + Score + "," + LetterGrade + "," + Sem;
    }
}
