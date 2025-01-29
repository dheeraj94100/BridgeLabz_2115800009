using System;

class GCDAndLCMCalculator
{
  
    static void Main()
    {
       
        int num1 = GetNumber("Enter the first number: ");
        int num2 = GetNumber("Enter the second number: ");

       
        int gcd = GetGCD(num1, num2);
        int lcm = GetLCM(num1, num2, gcd);

        Console.WriteLine($"GCD of {num1} and {num2} is: {gcd}");
        Console.WriteLine($"LCM of {num1} and {num2} is: {lcm}");
    }

   
    static int GetNumber(string prompt)
    {
        Console.Write(prompt); 
        return Convert.ToInt32(Console.ReadLine()); 
    }

    // Method to calculate the Greatest Common Divisor (GCD)
    static int GetGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a; // Return the GCD
    }

    // Method to calculate the Least Common Multiple (LCM)
    static int GetLCM(int a, int b, int gcd)
    {
        return (a * b) / gcd; // LCM formula: (a * b) / GCD(a, b)
    }
}
