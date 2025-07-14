using System;

public class HelloWorld
{
    public static void Factorial(int number)
    {
        int result = 1;
        for(int i=2; i<=number; i++)
        {
            result *= i;
        }
        Console.WriteLine("Factorial of " + number + " is: " + result);
    }
    public static void Main(string[] args)
    {
        Console.WriteLine ("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Factorial(number);
    }
}