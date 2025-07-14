using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }
        public char Grade { get; set; }

        public Student(string name)
        {
            Name = name;
            Marks = 0;
            Grade = 'D';
        }

        public Student(string name, int marks)
        {
            Name = name;
            Marks = marks;
            Grade = 'D';
        }

        public Student(string name, int marks, char grade)
        {
            Name = name;
            Marks = marks;
            Grade = grade;
        }

        public void AssignGrade()
        {
            if (Marks >= 90)
                Grade = 'A';
            else if (Marks >= 80)
                Grade = 'B';
            else if (Marks >= 70)
                Grade = 'C';
            else
                Grade = 'D';
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Marks: {Marks}, Grade: {Grade}");
        }
    }
}
