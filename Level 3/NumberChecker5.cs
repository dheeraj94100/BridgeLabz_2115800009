using System;

public class NumberChecker
{
    public static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());

        int[] factors = FindFactors(number);
        Console.WriteLine("Factors: " + string.Join(", ", factors));

        int greatestFactor = FindGreatestFactor(factors);
        Console.WriteLine("Greatest Factor: " + greatestFactor);

        int sumOfFactors = SumOfFactors(factors);
        Console.WriteLine("Sum of Factors: " + sumOfFactors);

        int productOfFactors = ProductOfFactors(factors);
        Console.WriteLine("Product of Factors: " + productOfFactors);

        double productOfCubeOfFactors = ProductOfCubeOfFactors(factors);
        Console.WriteLine("Product of Cube of Factors: " + productOfCubeOfFactors);

        bool isPerfectNumber = IsPerfectNumber(number);
        Console.WriteLine("Is Perfect Number: " + isPerfectNumber);

        bool isAbundantNumber = IsAbundantNumber(number);
        Console.WriteLine("Is Abundant Number: " + isAbundantNumber);

        bool isDeficientNumber = IsDeficientNumber(number);
        Console.WriteLine("Is Deficient Number: " + isDeficientNumber);

        bool isStrongNumber = IsStrongNumber(number);
        Console.WriteLine("Is Strong Number: " + isStrongNumber);
    }

    public static int[] FindFactors(int number)
    {
        int count = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }

        int[] factors = new int[count];
        int index = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factors[index++] = i;
            }
        }

        return factors;
    }

    public static int FindGreatestFactor(int[] factors)
    {
        int greatest = factors[0];
        foreach (int factor in factors)
        {
            if (factor > greatest)
            {
                greatest = factor;
            }
        }
        return greatest;
    }

    public static int SumOfFactors(int[] factors)
    {
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += factor;
        }
        return sum;
    }

    public static int ProductOfFactors(int[] factors)
    {
        int product = 1;
        foreach (int factor in factors)
        {
            product *= factor;
        }
        return product;
    }

    public static double ProductOfCubeOfFactors(int[] factors)
    {
        double product = 1;
        foreach (int factor in factors)
        {
            product *= Math.Pow(factor, 3);
        }
        return product;
    }

    public static bool IsPerfectNumber(int number)
    {
        if(number < 0)return false;

        int sum = 0;
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }
        return sum == number;
    }

    public static bool IsAbundantNumber(int number)
    {
        int sum = 0;
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }
        return sum > number;
    }

    public static bool IsDeficientNumber(int number)
    {
        int sum = 0;
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }
        return sum < number;
    }

    public static bool IsStrongNumber(int number)
    {
        int sum = 0;
        int temp = number;
        while (temp > 0)
        {
            int digit = temp % 10;
            sum += Factorial(digit);
            temp /= 10;
        }
        return sum == number;
    }

    public static int Factorial(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        return n * Factorial(n - 1);
    }
}