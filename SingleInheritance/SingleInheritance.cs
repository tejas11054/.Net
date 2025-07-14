using System;

public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal eats food");
    }
}

public class Mammal : Animal
{
    public void Walk(){
        Console.WriteLine("Mammal walks");
    }
}


class Program
{
    public static void Main(string [] args)
    {
        Mammal m = new Mammal();
        m.Eat();
        m.Walk();
    }
}
