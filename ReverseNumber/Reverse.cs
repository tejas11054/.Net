using System;

class Reverse
{

	public static void CalculateReverse(int number)
	{
		int sum = 0;

		while(number != 0)
		{
			int rem = number % 10;
			sum = (sum * 10) + rem;
			number /= 10;
		}

		Console.WriteLine("Reverse is : " + sum);
	}

	public static void Main(string [] args)
	{
		Console.WriteLine("Enter a number: ");
		int number = int.Parse(Console.ReadLine());
		CalculateReverse(number);

	}
}