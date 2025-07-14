using System;

class Prime{
	public static void CalculatePrime(int number){
		int flag = 0;
		for(int i=2; i<=number/2; i++){
			if(number%i == 0){
				flag = 1;
			}
		}
		if(flag == 0)
			Console.WriteLine(number + " is a prime number");
		else
			Console.WriteLine(number + " is not a prime number");
	}

	public static void Main(string [] args){
		Console.WriteLine("Enter a number: ");
		int number = int.Parse(Console.ReadLine());
		CalculatePrime(number);
	}
}