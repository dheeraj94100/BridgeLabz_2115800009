using System;

class Program
{
    static void Main()
    {
        double[][] data = new double[10][3]; // 10 rows for each person, 3 columns (weight, height, BMI)
        string[] status = new string[10];

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Enter details for person {i + 1}:");

            // Input weight (kg) and height (cm)
            Console.Write("Enter weight in kg: ");
            data[i, 0] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height in cm: ");
            data[i, 1] = Convert.ToDouble(Console.ReadLine());

            // Calculate BMI
            data[i, 2] = CalculateBMI(data[i, 0], data[i, 1]);

            // Determine BMI status
            status[i] = GetBMIStatus(data[i, 2]);

            // Display BMI and status
            Console.WriteLine($"Person {i + 1}: Weight = {data[i, 0]} kg, Height = {data[i, 1]} cm, BMI = {data[i, 2]:F2}, Status = {status[i]}\n");
        }
    }

    static double CalculateBMI(double weight, double height)
    {
        double heightInMeters = height / 100;
        return weight / (Math.Pow(heightInMeters, 2));
    }

    static string GetBMIStatus(double bmi)
    {
        if (bmi < 18.5)
            return "Underweight";
        else if (bmi >= 18.5 && bmi <= 24.9)
            return "Normal weight";
        else if (bmi >= 25 && bmi <= 39.9)
            return "Overweight";
        else
            return "Obesese";
    }
}
