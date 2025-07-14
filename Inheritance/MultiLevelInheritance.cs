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

public class Human : Mammal
{
    public void Speak(){
        Console.WriteLine("Human speaks");
    }
}

class Program
{
    public static void Main(string [] args)
    {
        Human h = new Human();
        h.Eat();
        h.Walk();
        h.Speak();
    }
}
