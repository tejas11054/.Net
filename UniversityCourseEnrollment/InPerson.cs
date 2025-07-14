using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityCourseEnrollment
{
    internal class InPerson : ICourse
    {
        public string CourseName { get; set; }
        public int RoomNumber { get; set; }
        public int StudentCapacity { get; set; }

        public void GetDetails()
        {
            Console.WriteLine("\nEnter the name of course");
            CourseName = Console.ReadLine();
            Console.WriteLine("Enter the room number");
            RoomNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the student capacity");
            StudentCapacity = int.Parse(Console.ReadLine());
        }

        public void DisplayCourseDetails()
        {
            Console.WriteLine($"\nCourse Name: {CourseName}, Room Number: {RoomNumber}, Student Capacity: {StudentCapacity}");
        }
    }
}
