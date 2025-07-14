namespace ProductApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product(101, "Laptop", 60000, 10);
            Product p2 = new Product(102, "Smartphone", 35000, 15);

            p1.DisplayDetails();
            p2.DisplayDetails();
        }
    }
}
