using System;

class BasicCalculator
{
   
    static void Main()
    {

        double num1 = GetNumber("Enter the first number: ");
        double num2 = GetNumber("Enter the second number: ");

        Console.WriteLine("Choose an operation (+, -, *, /): ");
        char operation = Console.ReadKey().KeyChar;
        Console.WriteLine(); 

        // Perform the chosen operation and display the result
        double result = PerformOperation(num1, num2, operation);
        Console.WriteLine($"Result: {result}");
    }

    // Method to get a number from the user
    static double GetNumber(string prompt)
    {
        Console.Write(prompt); // Prompt user for input
        return Convert.ToDouble(Console.ReadLine()); // Convert input to double
    }

    // Method to perform arithmetic operation based on user input
    static double PerformOperation(double num1, double num2, char operation)
    {
        switch (operation)
        {
            case '+': return num1 + num2;
            case '-': return num1 - num2;
            case '*': return num1 * num2;
            case '/': return num1 / num2;
            default:
                Console.WriteLine("Invalid operation!");
                return 0;
        }
    }
}



