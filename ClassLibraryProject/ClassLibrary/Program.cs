using MyClassLibrary;
namespace ClassLibraryProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("1234", "Tejas", 100000);
            Console.WriteLine(account.ToString());
        }
    }
}
