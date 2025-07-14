namespace StudentCollege
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Info");
            Student s1 = new Student(101, "Navi Mumbai", new DateTime(2004, 5, 30), "Computer");
            s1.DisplayInfo();

            Console.WriteLine("\nProfessor Info");
            Professor p1= new Professor(201, "Mumbai", new DateTime(1990, 2, 12), 50000, 10000, 8000);
            p1.DisplayInfo();
        }
    }
}
