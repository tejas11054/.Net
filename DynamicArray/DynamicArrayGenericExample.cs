using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    internal class DynamicArrayGenericExample
    {
        public static void Run()
        {
            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);

            foreach (int number in numbers)
            {
                Console.WriteLine($"{number} (Type: {number.GetType().Name})");
            }

            //Type-safe access (no casting)
            int first = numbers[0];
            Console.WriteLine($"First item as int: {first}");
        }
    }
}
