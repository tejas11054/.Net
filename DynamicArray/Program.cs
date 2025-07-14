namespace DynamicArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Non-Generic Dynamic Array (ArrayList) ===");
            DynamicArrayExample.Run();

            Console.WriteLine("\n=== Generic Dynamic Array (List<T>) ===");
            DynamicArrayGenericExample.Run();
        }
    }
}
