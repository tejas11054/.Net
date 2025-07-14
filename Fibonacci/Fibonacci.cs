using System;

class Fibonacci{
	public static void Main(string [] args){
		int n = 8;
		int a = 0, b = 1, c = 0;

		for(int i=1; i<=n; i++){
			c = a + b;
			a = b;
			b = c;
			Console.Write(a + " ");
		}
	}
}