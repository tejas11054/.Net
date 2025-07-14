using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int number = 1;
        Console.WriteLine("Printing numbers from 1 to 10");
        while(number <= 10)
        {
            Console.WriteLine(number);
            number++;
        }
    }
}