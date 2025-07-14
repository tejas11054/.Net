using System;

class Program
{
    static int FindTreasure(string direction)
    {
        if (direction == "left")
        {
            Console.WriteLine("What is your next move- (Swim or Wait)? ");
            string move = Console.ReadLine();

            if(move == "wait")
            {
                Console.WriteLine("Choose door color- ");
                string door = Console.ReadLine();

                if (door == "red")
                    Console.WriteLine("Burned by fire. Game Over");
                else if (door == "Blue")
                    Console.WriteLine("Eaten by beasts. Game Over");
                else if (door == "yellow")
                    Console.WriteLine("You Win");
                else
                    Console.WriteLine("Game Over");
            }
            else
            {
                Console.WriteLine("Attacked by trout. Game Over");
            }
        }
        else
        {
            Console.WriteLine("Fall into a hole. Game Over");
        }
        return 0;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Treasure Island");
        Console.WriteLine("Your mission is to find the treasure");
        Console.WriteLine("Enter Direction");
        string direction = Console.ReadLine();
        FindTreasure(direction);
    }
}
