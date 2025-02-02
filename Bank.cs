using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    class BankAccount
    {
        public string AccountNumber { get; set; }  // Public: Accessible everywhere
        protected string AccountHolder { get; set; }  // Protected: Accessible in derived classes
        private double Balance;  // Private: Only accessible within the class

        // Constructor
        public BankAccount(string accountNumber, string accountHolder, double initialBalance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = initialBalance;
        }

        // Public method to access and modify balance
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited: {amount}. New Balance: {Balance}");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn: {amount}. Remaining Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient balance or invalid amount!");
            }
        }

        public void DisplayBalance()
        {
            Console.WriteLine($"Account: {AccountNumber}, Balance: {Balance}");
        }
    }

    // Subclass demonstrating protected access
    class SavingsAccount : BankAccount
    {
        public double InterestRate { get; set; }

        public SavingsAccount(string accountNumber, string accountHolder, double initialBalance, double interestRate)
            : base(accountNumber, accountHolder, initialBalance)
        {
            InterestRate = interestRate;
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Savings Account - Number: {AccountNumber}, Holder: {AccountHolder}, Interest Rate: {InterestRate}%");
        }
    }

    class Program
    {
        static void Main()
        {
            BankAccount account = new BankAccount("ACC123", "Alice", 5000);
            account.Deposit(1000);
            account.Withdraw(2000);
            account.DisplayBalance();

            SavingsAccount savings = new SavingsAccount("SAV987", "Bob", 10000, 3.5);
            savings.DisplayAccountDetails();
        }
    }
}
