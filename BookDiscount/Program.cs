namespace BookDiscount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookDiscount book1 = new BookDiscount("The power of Habit", "Charles Duhigg", 600, true);
            book1.DisplayBookDetails();
            BookDiscount book2 = new BookDiscount("C# Basics", "Jane Doe", 450, false);
            book2.DisplayBookDetails();
        }
    }
}
