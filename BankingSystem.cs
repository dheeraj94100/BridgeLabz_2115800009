using System;
using System.Collections.Generic;

// Abstract class BankAccount
abstract class BankAccount
{
    private string accountNumber;
    private string holderName;
    private double balance;

    public BankAccount(string accountNumber, string holderName, double balance)
    {
        this.accountNumber = accountNumber;
        this.holderName = holderName;
        this.balance = balance;
    }

    public string AccountNumber { get { return accountNumber; } }
    public string HolderName { get { return holderName; } }
    public double Balance { get { return balance; } protected set { balance = value; } }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount:C} into account {AccountNumber}");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn {amount:C} from account {AccountNumber}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount or insufficient balance.");
        }
    }

    public abstract double CalculateInterest();

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Account Number: {AccountNumber}, Holder: {HolderName}, Balance: {Balance:C}");
    }
}

// Interface for loan eligibility
interface ILoanable
{
    void ApplyForLoan();
    double CalculateLoanEligibility();
}

// Savings Account
class SavingsAccount : BankAccount, ILoanable
{
    private double interestRate = 0.04; // 4% interest rate

    public SavingsAccount(string accountNumber, string holderName, double balance)
        : base(accountNumber, holderName, balance) { }

    public override double CalculateInterest()
    {
        return Balance * interestRate;
    }

    public void ApplyForLoan()
    {
        Console.WriteLine("Loan application submitted for savings account holder.");
    }

    public double CalculateLoanEligibility()
    {
        return Balance * 5; // Loan eligibility is 5x balance
    }
}

// Current Account
class CurrentAccount : BankAccount
{
    private double interestRate = 0.02; // 2% interest rate

    public CurrentAccount(string accountNumber, string holderName, double balance)
        : base(accountNumber, holderName, balance) { }

    public override double CalculateInterest()
    {
        return Balance * interestRate;
    }
}

class Program
{
    static void Main()
    {
        List<BankAccount> accounts = new List<BankAccount>();

        Console.Write("Enter number of accounts: ");
        int numAccounts = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numAccounts; i++)
        {
            Console.WriteLine("\nEnter details for Account " + (i + 1));
            Console.Write("Enter Account Number: ");
            string number = Console.ReadLine();

            Console.Write("Enter Holder Name: ");
            string holder = Console.ReadLine();

            Console.Write("Enter Initial Balance: ");
            double balance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Account Type (Savings/Current): ");
            string type = Console.ReadLine().ToLower();

            if (type == "savings")
            {
                accounts.Add(new SavingsAccount(number, holder, balance));
            }
            else if (type == "current")
            {
                accounts.Add(new CurrentAccount(number, holder, balance));
            }
            else
            {
                Console.WriteLine("Invalid Account Type. Skipping entry.");
            }
        }

        Console.WriteLine("\nBank Account Details:");
        foreach (var account in accounts)
        {
            account.DisplayDetails();
            Console.WriteLine($"Interest Earned: {account.CalculateInterest():C}");

            if (account is ILoanable loanable)
            {
                Console.WriteLine("Loan Eligibility: " + loanable.CalculateLoanEligibility().ToString("C"));
            }
            Console.WriteLine();
        }
    }
}
