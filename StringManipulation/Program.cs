namespace StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = args[0];

            string[] parts = input.Split(',');
            if (parts.Length == 3)
            {
                Console.WriteLine("Developer name is : " + parts[0]);
                Console.WriteLine("Company name is : " + parts[1]);
                Console.WriteLine("Location is : " + parts[2]);
            }
            else
                Console.WriteLine("Invalid input format");
        }
    }
}
