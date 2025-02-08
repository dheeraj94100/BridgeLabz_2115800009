using System;

// Base class: BankAccount
class BankAccount
{
    public int AccountNumber { get; set; }
    public double Balance { get; set; }

    // Constructor to initialize account details
    public BankAccount(int accountNumber, double balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }

    // Method to display common account details
    public virtual void DisplayAccountDetails()
    {
        Console.WriteLine($"Account Number: {AccountNumber}, Balance: ₹{Balance}");
    }

    // Virtual method to be overridden in subclasses
    public virtual void DisplayAccountType()
    {
        Console.WriteLine("This is a general bank account.");
    }
}

// Subclass: SavingsAccount
class SavingsAccount : BankAccount
{
    public double InterestRate { get; set; }

    // Constructor to initialize savings account details
    public SavingsAccount(int accountNumber, double balance, double interestRate)
        : base(accountNumber, balance)
    {
        InterestRate = interestRate;
    }

    // Overriding method to specify the account type
    public override void DisplayAccountType()
    {
        Console.WriteLine("This is a Savings Account.");
    }

    // Display details specific to Savings Account
    public override void DisplayAccountDetails()
    {
        base.DisplayAccountDetails();
        Console.WriteLine($"Interest Rate: {InterestRate}%");
    }
}

// Subclass: CheckingAccount
class CheckingAccount : BankAccount
{
    public double WithdrawalLimit { get; set; }

    // Constructor to initialize checking account details
    public CheckingAccount(int accountNumber, double balance, double withdrawalLimit)
        : base(accountNumber, balance)
    {
        WithdrawalLimit = withdrawalLimit;
    }

    // Overriding method to specify the account type
    public override void DisplayAccountType()
    {
        Console.WriteLine("This is a Checking Account.");
    }

    // Display details specific to Checking Account
    public override void DisplayAccountDetails()
    {
        base.DisplayAccountDetails();
        Console.WriteLine($"Withdrawal Limit: ₹{WithdrawalLimit} per transaction");
    }
}

// Subclass: FixedDepositAccount
class FixedDepositAccount : BankAccount
{
    public int MaturityPeriod { get; set; } // In months
    public double InterestRate { get; set; }

    // Constructor to initialize fixed deposit account details
    public FixedDepositAccount(int accountNumber, double balance, int maturityPeriod, double interestRate)
        : base(accountNumber, balance)
    {
        MaturityPeriod = maturityPeriod;
        InterestRate = interestRate;
    }

    // Overriding method to specify the account type
    public override void DisplayAccountType()
    {
        Console.WriteLine("This is a Fixed Deposit Account.");
    }

    // Display details specific to Fixed Deposit Account
    public override void DisplayAccountDetails()
    {
        base.DisplayAccountDetails();
        Console.WriteLine($"Maturity Period: {MaturityPeriod} months, Interest Rate: {InterestRate}%");
    }
}

// Main class to demonstrate functionality
class Program
{
    static void Main()
    {
        // Creating a Savings Account
        SavingsAccount savings = new SavingsAccount(101, 50000, 4.5);
        savings.DisplayAccountType();
        savings.DisplayAccountDetails();

        Console.WriteLine();

        // Creating a Checking Account
        CheckingAccount checking = new CheckingAccount(102, 20000, 5000);
        checking.DisplayAccountType();
        checking.DisplayAccountDetails();

        Console.WriteLine();

        // Creating a Fixed Deposit Account
        FixedDepositAccount fixedDeposit = new FixedDepositAccount(103, 100000, 12, 6.5);
        fixedDeposit.DisplayAccountType();
        fixedDeposit.DisplayAccountDetails();
    }
}