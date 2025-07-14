using System;

class Program
{
    static int GenerateDenomination(int amount)
    {
        int twoThousand = 0, fiveHundred = 0, twoHundred = 0, oneHundred = 0;
        
        if(amount % 100 != 0)
        {
            Console.WriteLine("Amount should be in multiple of 100");
            return 0;
        }

        if(amount > 50000)
        {
            Console.WriteLine("Amount exceed withdrawal limit of 50000");
            return 0;
        }

        twoThousand = amount / 2000;
        amount %= 2000;

        fiveHundred = amount / 500;
        amount %= 500;

        twoHundred = amount / 200;
        amount %= 200;

        oneHundred = amount / 100;
        amount %= 100;

        Console.WriteLine("Two Thousand : " + twoThousand);
        Console.WriteLine("Five Hundred : " + fiveHundred);
        Console.WriteLine("Two Hundred : " + twoHundred);
        Console.WriteLine("Hundred : " + oneHundred);
        return 0;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Withdrawal amount");
        int amount = Convert.ToInt32(Console.ReadLine());
        GenerateDenomination(amount);
    }
}
