using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp
{
    public class Account
    {
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public string BankName { get; set; }
        public double Balance { get; set; }

        public const double MIN_BALANCE = 500;

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine("\nAmount Deposited Successfully");
        }

        public void Withdraw(double amount)
        {
            if (Balance - amount >= MIN_BALANCE)
            {
                Balance -= amount;
                Console.WriteLine("\nAmount withdrawn successfully");
            }
            else
                Console.WriteLine("\nInsufficient Balance: Min 500 should be maintained");
        }

        public double CheckBalance()
        {
            return Balance;
        }
    }
}
