using System;

class BankAccount
{
    private static string bankName = "Global Bank";
    private static int totalAccounts = 0;

    public readonly int AccountNumber;
    public string AccountHolderName;
    private double balance;

    // Constructor using 'this' to resolve ambiguity
    public BankAccount(string AccountHolderName, int AccountNumber, double initialDeposit)
    {
        this.AccountHolderName = AccountHolderName;
        this.AccountNumber = AccountNumber;
        this.balance = initialDeposit;
        totalAccounts++;
    }

    // Static method to get total number of accounts
    public static void GetTotalAccounts()
    {
        Console.WriteLine($"Total Accounts: {totalAccounts}");
    }

    // Method to deposit amount
    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited {amount}. New Balance: {balance}");
    }

    // Method to withdraw amount
    public void Withdraw(double amount)
    {
        if (amount > balance)
            Console.WriteLine("Insufficient balance!");
        else
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn {amount}. New Balance: {balance}");
        }
    }

    // Display account details using 'is' operator for type checking
    public void DisplayAccountInfo()
    {
        if (this is BankAccount)
        {
            Console.WriteLine($"\nBank: {bankName}");
            Console.WriteLine($"Account Holder: {AccountHolderName}");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Current Balance: {balance}\n");
        }
        else
        {
            Console.WriteLine("Invalid account object!");
        }
    }
}

class BankAccount1
{
    static void Main()
    {
        Console.WriteLine("Enter Account Holder Name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter Account Number: ");
        int accNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Initial Deposit: ");
        double deposit = Convert.ToDouble(Console.ReadLine());




        // Creating a bank account using user input
        BankAccount userAccount = new BankAccount(name, accNumber, deposit);

        // Displaying account details
        userAccount.DisplayAccountInfo();

        // Performing deposit
        Console.Write("\nEnter amount to deposit: ");
        double depositAmount = Convert.ToDouble(Console.ReadLine());
        userAccount.Deposit(depositAmount);

        // Performing withdrawal
        Console.Write("Enter amount to withdraw: ");
        double withdrawAmount = Convert.ToDouble(Console.ReadLine());
        userAccount.Withdraw(withdrawAmount);

        // Display updated account details
        userAccount.DisplayAccountInfo();

        // Display total accounts using static method
        BankAccount.GetTotalAccounts();
    }
}

