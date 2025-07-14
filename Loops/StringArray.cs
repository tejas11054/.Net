using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string[] movies = {"Chhava", "Gladiator", "Housefull"};
        Console.WriteLine("Printing string array elements");
        for(int i=0; i<movies.Length; i++)
        {
            Console.WriteLine(movies[i]);
        }
    }
}