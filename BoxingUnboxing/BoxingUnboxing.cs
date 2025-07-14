using System;

class Program
{
    public static void Main(string [] args)
    {
        int num = 42;
        Object obj = num; // Boxing
        Console.WriteLine("Boxed value = " + obj);
        
        num = 100;
        
        int unBoxedNum = (int) obj;
        Console.WriteLine("Unboxed value = " + unBoxedNum); // Unboxing
        
        Console.WriteLine("Original int after modifications = " + num);
    }
}
