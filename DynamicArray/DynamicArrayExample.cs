using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    internal class DynamicArrayExample
    {
        public static void Run()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Hello");
            arrayList.Add(3.14);

            foreach (var item in arrayList)
            {
                Console.WriteLine($"{item} (Type: {item.GetType().Name})");
            }

            //Type casting is required
            int num = (int)arrayList[0];
            Console.WriteLine($"First item as int: {num}");

        }
    }
}
