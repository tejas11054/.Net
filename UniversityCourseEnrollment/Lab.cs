using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityCourseEnrollment
{
    internal class Lab : ICourse
    {
        public string CourseName { get; set; }
        public string SafetyTrainingCompletion { get; set; }

     public void GetDetails()
        {
            Console.WriteLine("\nEnter the name of course");
            CourseName = Console.ReadLine();
            Console.WriteLine("Enter the safety training completion certificate number");
            SafetyTrainingCompletion = Console.ReadLine();
        }

        public void DisplayCourseDetails()
        {
            Console.WriteLine($"\nCourse Name: {CourseName}, Safety Training Completion Certificate Number: {SafetyTrainingCompletion}");
        }
    }
}
