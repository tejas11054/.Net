using System;
namespace MagicMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < sentence.Length; i++)
                if (sentence[i] == ' ') { count++; }
            Console.WriteLine("Total Spaces: " + count);
        }
    }
}
