using System.Text.Json;

namespace AccountApp
{
    internal class Program
    {
        static string filePath = $"D:\\Swabhav\\Assignment\\account.json";

        public static void Execute()
        {
            Account account;

            if (File.Exists(filePath))
            {
                Console.WriteLine("Welcome Back");
                string json = File.ReadAllText(filePath);
                account = JsonSerializer.Deserialize<Account>(json);
                Console.WriteLine($"Account Balance is: {account.Balance}");
            }
            else
            {
                account = new Account();
                Console.WriteLine("Welcome! Enter Account Details to create new account");

                Console.Write("Account Number: ");
                account.AccountNumber = int.Parse(Console.ReadLine());
                Console.Write("Account Holder Name: ");
                account.AccountHolderName = Console.ReadLine();
                Console.Write("Account Bank Name: ");
                account.BankName = Console.ReadLine();
                Console.Write("Opening Balance: ");
                double Balance = double.Parse(Console.ReadLine());

                while (Balance < 500)
                {
                    Console.Write("Minimum balance has to be above 500. Re-neter: ");
                    Balance = double.Parse(Console.ReadLine());
                }

                account.Balance = Balance;
                Console.WriteLine("\nAccont has been created successfully");
            }

            int choice;
            do
            {
                Console.WriteLine("\nWhat do you wish to do? ");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Display Balance");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter amount to deposit: ");
                        double depositAmount = double.Parse(Console.ReadLine());
                        account.Deposit(depositAmount);
                        break;

                    case 2:
                        Console.Write("Enter amount to withdraw: ");
                        double withdrawAmount = double.Parse(Console.ReadLine());
                        account.Withdraw(withdrawAmount);
                        break;

                    case 3:
                        Console.WriteLine($"Balance for Account Number {account.AccountNumber} is {account.Balance}");
                        break;

                    case 4:
                        Console.WriteLine("Thank you for using the app.....");
                        break;

                    default:
                        Console.WriteLine("ENter the valid choice");
                        break;
                }

                string updateJson = JsonSerializer.Serialize(account, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, updateJson);
            } while (choice != 4);
        }
        static void Main(string[] args)
        {
            Execute();
        }
    }
}
