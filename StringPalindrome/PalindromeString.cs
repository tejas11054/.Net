using System;

public class HelloWorld
{
    public static string Palindrome(string str)
    {
        string result = "";
        for(int i=str.Length - 1; i>=0; i--)
        {
            result += str[i];
        }
	if(result == str)
	{
		return "Palindrome";
	}
	return "Not Palindrome";
      
    }
    public static void Main(string[] args)
    {
        Console.WriteLine ("Enter a string: ");
        string str = Console.ReadLine();
        Console.WriteLine(Palindrome(str));
    }
}