using System;

class BMICalculation {
    static void Main() {
        Console.WriteLine("Enter the number of persons:");
        int personCount = Convert.ToInt32(Console.ReadLine()); // Input number of persons

        double[,] personData = new double[personCount, 3]; // Array to store height, weight, and BMI
        string[] weightStatus = new string[personCount]; // Array to store BMI categories

        // Loop to collect data for each person
        for (int i = 0; i < personCount; i++) {
            Console.WriteLine($"Enter height (m) and weight (kg) for Person {i + 1}:");
            double height = Convert.ToDouble(Console.ReadLine()); // Input and convert height
            double weight = Convert.ToDouble(Console.ReadLine()); // Input and convert weight

            // Validate input
            if (height <= 0 || weight <= 0) {
                Console.WriteLine("Invalid input. Please enter positive values.");
                i--; // Retry for the same person
                continue;
            }

            // Calculate BMI
            double bmi = weight / (height * height);
            personData[i, 0] = height;
            personData[i, 1] = weight;
            personData[i, 2] = bmi;

            // Determine BMI category
            weightStatus[i] = (bmi < 18.5) ? "Underweight" :
                              (bmi < 24.9) ? "Normal" :
                              (bmi < 29.9) ? "Overweight" : "Obese";
        }

        // Display results in a tabular format
        Console.WriteLine("Height(m)\tWeight(kg)\tBMI\t\tStatus");
        for (int i = 0; i < personCount; i++) {
            Console.WriteLine($"{personData[i, 0]:F2}\t\t{personData[i, 1]:F2}\t\t{personData[i, 2]:F2}\t\t{weightStatus[i]}");
        }
    }
}