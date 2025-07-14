using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BankManagement
{
    internal class Account
    {
        private static Random rand = new Random();
        private static string[] existingAccountNumbers = new string[3];
        private static int accountCount = 0;

        public string AccountNumber { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public string AccountType { get; set; }

        public Account(string name, string accounttype, double initialDeposit)
        {
            Name = name;
            AccountType = accounttype;
            Balance = initialDeposit >= 500 ? initialDeposit : 500;
            AccountNumber = GenerateUniqueAccountNumber();
        }

        public string GenerateUniqueAccountNumber()
        {
            string accountNumber;
            do
            {
                accountNumber = "IDBI1000" + rand.Next(1000000, 9999999);
            } while(Array.Exists(existingAccountNumbers, num => num ==  accountNumber));

            existingAccountNumbers[accountCount++] = accountNumber;
            return accountNumber;
        }

        public void Deposit(double amount)
        {
            if(amount > 0)
            {
                Balance += amount;
                Console.WriteLine("Amount Deposited Successfully");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && Balance - amount >= 500)
            {
                Balance -= amount;
                Console.WriteLine("Amount withdrawn Successfully");
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }

        public override string ToString()
        {
            string value = $"Account Number: {AccountNumber}\t Name: {Name}\t Account Type: {AccountType}\t Balanec: {Balance}";
            return value;
        }
    }
}
