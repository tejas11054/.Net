using System;

class Palindrome
{
    public static void DecidePalindrome(int number)
    {
        int num = number;
        int sum = 0;
        
        while(num != 0)
        {
            int rem = num % 10;
            sum = (sum * 10) + rem;
            num /= 10;
        }
        
        if(sum == number)
            Console.WriteLine(number + " is Palindrome");
        else
            Console.WriteLine(number + " is not Palindrome");
    }
    
    public static void Main(string [] args)
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        
        DecidePalindrome(number);
    }
}