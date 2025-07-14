using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityCourseEnrollment 
{
    internal class Online : ICourse
    {
        public string CourseName {  get; set; }
        public string VideoPlatformLink { get; set; }
        public void GetDetails()
        {
            Console.WriteLine("\nEnter the name of course");
            CourseName = Console.ReadLine();
            Console.WriteLine("Enter the video platform link");
            VideoPlatformLink = Console.ReadLine();
        }

        public void DisplayCourseDetails()
        {
            Console.WriteLine($"\nCourse Name: {CourseName}, Video Platform Link: {VideoPlatformLink}");
        }
    }
}
