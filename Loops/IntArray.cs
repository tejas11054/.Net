using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] numbers = {11,22,33,44,55};
        Console.WriteLine("Printing array elements");
        for(int i=0; i<numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}