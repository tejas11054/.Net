namespace BankManagement
{
    internal class Program
    {
        static Account[] accounts = new Account[3];
        static int index = 0;
        
        static void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("1. Create an Account");
                Console.WriteLine("2. View Balance");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Withdraw");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CreateAccount();
                        break;

                    case 2:
                        ViewBalance();
                        break;

                    case 3:
                        Deposit();
                        break;

                    case 4:
                        Withdraw();
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }

        static void CreateAccount()
        {
            if(index >=  accounts.Length)
            {
                Console.WriteLine("Account limit reached");
                return;
            }

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter account type (savings/current): ");
            string type = Console.ReadLine();
            Console.Write("Enter initial deposit amount: ");
            double amount = double.Parse(Console.ReadLine());

            accounts[index] = new Account(name, type, amount);
            Console.WriteLine("Account has been created successfully");
            Console.WriteLine(accounts[index].ToString());
            index++;
        }

        static Account FindAccount()
        {
            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine();

            for(int i=0; i<accounts.Length; i++)
            {
                if(accounts[i].AccountNumber == accountNumber)
                    return accounts[i];
            }
            Console.WriteLine("Account not found");
            return null;
        }

        static void ViewBalance()
        {
            var account = FindAccount();
            if(account != null) 
                Console.WriteLine($"Balance: {account.Balance}");
        }

        static void Deposit()
        {
            var account = FindAccount();
            if (account != null)
            {
                Console.Write("Enter amount to deposit: ");
                double amount = double.Parse(Console.ReadLine());
                account.Deposit(amount);
            }
        }

        static void Withdraw()
        {
            var account = FindAccount();
            if (account != null)
            {
                Console.Write("Enter amount to withdraw: ");
                double amount = double.Parse(Console.ReadLine());
                account.Withdraw(amount);
            }
                
        }
        static void Main(string[] args)
        {
            ShowMenu();

        }
    }
}
