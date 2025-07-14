*/
Constructor Chaining

Constructor chaining is the process where one constructor in a class calls another constructor in the same class or a constructor in its base class. 
This technique helps to reuse initialization logic and reduce code duplication, especially when dealing with multiple overloaded constructors. 
*/

using System;
namespace ConstructorChaining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Constructor chaining");
            SingleClass singleClass = new SingleClass();
            SingleClass singleClass1 = new SingleClass(100);
        }
    }

    public class SingleClass
    {
        public SingleClass(int num) : this("s")
        {
            Console.WriteLine("In Constructor 1");
        }

        public SingleClass(): this(10)
        {
            Console.WriteLine("In Default Constructor");
        }

        public SingleClass(string str)
        {
            Console.WriteLine(str);
        }
    }
}
