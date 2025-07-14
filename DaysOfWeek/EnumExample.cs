/*
Enum

an enum short for enumeration is a value type that defines a set of named constants. 
It's a way to represent a fixed number of related values, making your code more readable and maintainable. 

*/

// Enum for days of week

using System;

public class EnumExample
{
    private enum DaysOfWeek
    {
        Sunday = 1,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number (1-7): ");
        int dayNumber = int.Parse(Console.ReadLine());
        DaysOfWeek day = (DaysOfWeek)dayNumber;
        Console.WriteLine("The day is " + day);

    }
}