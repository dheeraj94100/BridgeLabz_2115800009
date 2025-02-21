using System;

class Program
{
    static double CalculateInterest(double amount, double rate, int years)
    {
        if (amount < 0 || rate < 0)
        {
            throw new ArgumentException("Invalid input: Amount and rate must be positive");
        }
        return amount * rate * years / 100;
    }

    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter principal amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter interest rate: ");
            double rate = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter number of years: ");
            int years = Convert.ToInt32(Console.ReadLine());
            
            double interest = CalculateInterest(amount, rate, years);
            Console.WriteLine($"Calculated Interest: {interest}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid numeric values.");
        }
    }
}
