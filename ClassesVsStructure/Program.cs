namespace ClassesVsStructures
{
    struct PersonStruct
    {
        public string Name;
        public int Age;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Class Demo with reference type-------");
            PersonClass pc1 = new PersonClass();
            pc1.Name = "Tejas";
            pc1.Age = 22;

            PersonClass pc2 = pc1; //pc2 points to the same object
            pc2.Name = "Ramane";

            Console.WriteLine("pc1 Name = " + pc1.Name);
            Console.WriteLine("pc2 Name = " + pc2.Name);

            Console.WriteLine("\n-------Struct dmeo with value type-------");
            PersonStruct ps1 = new PersonStruct();
            ps1.Name = "Rohit";
            ps1.Age = 32;

            PersonStruct ps2 = ps1; //ps2 is a copy of ps1
            ps2.Name = "Sharma";

            Console.WriteLine("ps1 Name = " + ps1.Name);
            Console.WriteLine("ps2 Name = " + ps2.Name);
        }
    }
}
