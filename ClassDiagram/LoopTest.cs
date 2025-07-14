using System;

namespace CodingStandards

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Tejas Ramane";

            Console.WriteLine("Using FOR loop:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nUsing WHILE loop:");
            int j = 0;
            while (j < 5)
            {
                Console.WriteLine(name);
                j++;
            }
        }
    }
}
