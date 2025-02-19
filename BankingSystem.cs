using System;
using System.Collections.Generic;
using System.Linq;

class BankingSystem
{
    static void Main()
    {
        Dictionary<int, double> accountBalances = new Dictionary<int, double>(); // Stores account balances
        SortedDictionary<double, List<int>> sortedBalances = new SortedDictionary<double, List<int>>(); // Sorts by balance
        Queue<int> withdrawalQueue = new Queue<int>(); // Processes withdrawals

        Console.Write("Enter the number of bank accounts: ");
        int numAccounts = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numAccounts; i++)
        {
            Console.Write($"Enter account number {i + 1}: ");
            int accountNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Enter balance for account {accountNumber}: ");
            double balance = Convert.ToDouble(Console.ReadLine());

            // Store in dictionary
            accountBalances[accountNumber] = balance;

            // Sort by balance
            if (!sortedBalances.ContainsKey(balance))
                sortedBalances[balance] = new List<int>();
            
            sortedBalances[balance].Add(accountNumber);
        }

        Console.Write("\nEnter the number of withdrawal requests: ");
        int numWithdrawals = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numWithdrawals; i++)
        {
            Console.Write("Enter account number for withdrawal: ");
            int accountNumber = Convert.ToInt32(Console.ReadLine());

            // Queue the withdrawal request
            if (accountBalances.ContainsKey(accountNumber))
                withdrawalQueue.Enqueue(accountNumber);
            else
                Console.WriteLine("Invalid account number.");
        }

        // Process withdrawals
        Console.WriteLine("\nProcessing Withdrawals:");
        while (withdrawalQueue.Count > 0)
        {
            int accountNumber = withdrawalQueue.Dequeue();
            Console.Write($"Enter withdrawal amount for account {accountNumber}: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (accountBalances[accountNumber] >= amount)
            {
                accountBalances[accountNumber] -= amount;
                Console.WriteLine($"Withdrawal successful. New balance: ${accountBalances[accountNumber]:F2}");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

        // Display accounts sorted by balance
        Console.WriteLine("\nAccounts Sorted by Balance:");
        foreach (var kvp in sortedBalances)
        {
            foreach (var account in kvp.Value)
            {
                Console.WriteLine($"Account {account}: ${kvp.Key:F2}");
            }
        }
    }
}
