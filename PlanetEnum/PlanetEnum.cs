using System;

namespace Assignment
{
    internal enum Planet
    {
        EARTH,
        MARS,
        JUPITER
    }
    internal class Program
    {
        public static double GetGravity(Planet planet)
        {
            if (planet == Planet.MARS)
                return 0.377;
            else if (planet == Planet.JUPITER)
                return 2.37;
            else
                return 1.0;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter earth weight: ");
	    double earthWeight = double.Parse(Console.ReadLine());
                double marsWeight = earthWeight * GetGravity(Planet.MARS);
                double jupiterWeight = earthWeight * GetGravity(Planet.JUPITER);

                Console.WriteLine("Weight on Mars: " + marsWeight + " kg");
                Console.WriteLine("Weight on Jupiter: " + jupiterWeight + " kg");

        }
    }
}
