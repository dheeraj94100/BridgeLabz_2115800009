using System;
using System.Collections.Generic;

public class Bank
{
    public string Name { get; set; }
    public List<Customer> Customers { get; set; }

    public Bank(string name)
    {
        Name = name;
        Customers = new List<Customer>();
    }

    public void OpenAccount(Customer customer, decimal initialDeposit)
    {
        Account newAccount = new Account(this, initialDeposit);
        customer.Accounts.Add(newAccount);
        if (!Customers.Contains(customer))
        {
            Customers.Add(customer);
        }
        Console.WriteLine($"Account opened for {customer.Name} with initial deposit of {initialDeposit:C}.");
    }
}

public class Customer
{
    public string Name { get; set; }
    public List<Account> Accounts { get; set; }

    public Customer(string name)
    {
        Name = name;
        Accounts = new List<Account>();
    }

    public void ViewBalance()
    {
        foreach (var account in Accounts)
        {
            Console.WriteLine($"Account in {account.Bank.Name} has balance: {account.Balance:C}");
        }
    }
}

public class Account
{
    public Bank Bank { get; set; }
    public decimal Balance { get; set; }

    public Account(Bank bank, decimal initialDeposit)
    {
        Bank = bank;
        Balance = initialDeposit;
    }
}

public class Program
{
    public static void Main()
    {
        Bank bank = new Bank("Global Bank");
        Customer customer = new Customer("John Doe");

        bank.OpenAccount(customer, 1000m);
        customer.ViewBalance();
    }
}