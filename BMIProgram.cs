using System;

class BMI
{
    static void Main(string[] args)
    {
        // Taking user input for weight (in kg) and height (in cm)
        Console.Write("Enter your weight in kg: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter your height in cm: ");
        double heightInCm = Convert.ToDouble(Console.ReadLine());

        // Convert height from cm to meters
        double heightInM = heightInCm / 100;

        // Calculate BMI using the formula
        double bmi = weight / (heightInM * heightInM);

        // Output the BMI value
        Console.WriteLine($"\nYour BMI is: {bmi:F2}");

        // Determine weight status based on BMI
        if (bmi < 18.5)
        {
            Console.WriteLine("Underweight");
        }
        else if (bmi >= 18.5 && bmi < 24.9)
        {
            Console.WriteLine("Normal");
        }
        else if (bmi >= 25 && bmi < 29.9)
        {
            Console.WriteLine("Overweight");
        }
        else
        {
            Console.WriteLine("Obese");
        }
    }
}