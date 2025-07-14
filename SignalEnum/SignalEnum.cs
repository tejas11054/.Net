using System;

namespace Assignment
{
    internal enum TrafficLight
    {
        RED,
        YELLOW,
        GREEN
    }
    internal class Program
    {
        public static void showTrafficSignalAction(TrafficLight signal)
        {
            switch (signal)
            {
                case TrafficLight.RED:
                    Console.WriteLine("Signal: RED -> Stop");
                    break;

                case TrafficLight.YELLOW:
                    Console.WriteLine("Signal: YELLOW -> Get Ready");
                    break;

                case TrafficLight.GREEN:
                    Console.WriteLine("Signal: GREEN -> Go");
                    break;

                default:
                    Console.WriteLine("Unknown Signal");
                    break;
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter traffic signal (RED, YELLOW, GREEN): ");
            string input = Console.ReadLine();
	TrafficLight signal;
	bool isParsed = Enum.TryParse(input, out signal);


            if (isParsed)
            {
                showTrafficSignalAction(signal);
            }

        }
    }
}
