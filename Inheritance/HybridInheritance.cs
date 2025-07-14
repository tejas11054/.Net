using System;

interface IAnimal
{
    void Eat();
}

interface IWalker
{
    void Walk();
}

public class Mammal : IAnimal
{
    public void Eat()
    {
        Console.WriteLine("Mammal eats");
    }
}

public class Human : Mammal, IWalker
{
    public void Walk()
    {
        Console.WriteLine("Human walks");
    }
    
    public void Speak()
    {
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
