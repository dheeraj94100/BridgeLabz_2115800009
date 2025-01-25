using System;
class BMICalculator2D {
    static void Main() {
        Console.WriteLine("Enter the number of persons:");
        int number = Convert.ToInt32(Console.ReadLine());

        double[][] personData = new double[number][];
        string[] statuses = new string[number];

        for (int i = 0; i < number; i++) {
            personData[i] = new double[3]; // [height, weight, BMI]

            Console.WriteLine($"Person {i + 1}:");
            do {
                Console.Write("Enter height (in meters): ");
                personData[i][0] = Convert.ToDouble(Console.ReadLine());
            } while (personData[i][0] <= 0);

            do {
                Console.Write("Enter weight (in kilograms): ");
                personData[i][1] = Convert.ToDouble(Console.ReadLine());
            } while (personData[i][1] <= 0);

            personData[i][2] = personData[i][1] / (personData[i][0] * personData[i][0]);

            statuses[i] = personData[i][2] < 18.5 ? "Underweight" :
                          personData[i][2] < 24.9 ? "Normal weight" :
                          personData[i][2] < 29.9 ? "Overweight" : "Obese";
        }
      // Display marks, percentage, and grades for all students
        Console.WriteLine("\nBMI Results:");
        for (int i = 0; i < number; i++) {
            Console.WriteLine($"Person {i + 1}: Height = {personData[i][0]} m, Weight = {personData[i][1]} kg, BMI = {personData[i][2]:F2}, Status = {statuses[i]}");
        }
    }
}