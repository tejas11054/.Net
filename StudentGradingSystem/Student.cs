using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradingSystem
{
    internal class Student
    {
        private string studentName;
        private string rollNumber;
        private int[] marks;

        public Student(string studentName, string rollNumber, int[] marks)
        {
            this.studentName = studentName;
            this.rollNumber = rollNumber;
            this.marks = marks;
        }

        public double CalculateAverage()
        {
            return marks.Average();
        }

        public string CalculateGrade()
        {
            double average = marks.Average();

            if (average >= 90) return "A+";
            else if (average >= 80) return "A";
            else if (average >= 70) return "B";
            else if (average >= 60) return "C";
            else if (average >= 50) return "D";
            else return "Fail";
        }

        public override string ToString()
        {
            string markList = "[" + string.Join(", ", marks) + "]";
            double average = CalculateAverage();
            string grade = CalculateGrade();

            return $"Student Report Card\n" +
                $"-------------------------\n" +
                $"Name      : {studentName}\n" +
                $"Roll No   : {rollNumber}\n" +
                $"Marks     : {markList}\n" +
                $"Average   : {average}\n" +
                $"Grade     : {grade}\n";
        }
    }
}
