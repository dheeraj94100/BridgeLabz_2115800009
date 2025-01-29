using System;

class MaximumOfThreeNumbers
{
  
    static void Main()
    {
      
        int num1 = GetNumber("Enter the first number: ");
        int num2 = GetNumber("Enter the second number: ");
        int num3 = GetNumber("Enter the third number: ");

       
        int max = GetMaximum(num1, num2, num3);

        
        Console.WriteLine($"The maximum number is: {max}");
    }

    // Method to get a number from the user
    static int GetNumber(string prompt)
    {
        Console.Write(prompt); 
        return Convert.ToInt32(Console.ReadLine()); // Convert input to integer
    }

    
    static int GetMaximum(int num1, int num2, int num3)
    {
        return Math.Max(num1, Math.Max(num2, num3)); // Use Math.Max to find the largest number
    }
}
