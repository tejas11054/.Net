namespace StudentGradingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter roll number");
            string rollnumber = Console.ReadLine();

            int[] marks = new int[5];
            for(int i = 0; i < marks.Length; i++)
            {
                Console.Write("Enter marks for subject " + (i + 1));
                marks[i] = int.Parse(Console.ReadLine());
            }

            Student student = new Student(name, rollnumber, marks);
            Console.WriteLine(student);
        }
    }
}
