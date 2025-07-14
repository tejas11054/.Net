namespace UniversityCourseEnrollment
{
    internal class Program
    {
        public static void ShowMenu()
        {
            Console.WriteLine("\nEnter the type of course want to Add (Online / In Person / Lab): ");
            string courseType = Console.ReadLine().ToLower();

            switch (courseType)
            {
                case "online":
                    Online online = new Online();
                    online.GetDetails();
                    online.DisplayCourseDetails();
                    break;

                case "in person":
                    InPerson person = new InPerson();
                    person.GetDetails();
                    person.DisplayCourseDetails();
                    break;

                case "lab":
                    Lab lab = new Lab();
                    lab.GetDetails();
                    lab.DisplayCourseDetails();
                    break;

                default:
                    Console.WriteLine("Enter valid course type");
                    break;
            }
        }
        static void Main(string[] args)
        {
            ShowMenu();
        }
    }
}
