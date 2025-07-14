namespace Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(1, "ABC", 25, 1.65, 60);
            Console.WriteLine($"{person1.Name}'s BMI: {person1.CalculateBMI()}");
            Console.WriteLine($"{person1.Name}'s Body Type: {person1.GetBodyType()}");

            Person person2 = new Person(2, "XYZ", 39);
            Console.WriteLine($"{person2.Name}'s BMI: {person2.CalculateBMI()}");
            Console.WriteLine($"{person2.Name}'s Body Type: {person2.GetBodyType()}");
        }
    }
}
