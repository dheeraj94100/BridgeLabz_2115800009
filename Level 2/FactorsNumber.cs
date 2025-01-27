using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        // Get factors of the number
        int[] answers = Factors(number);
        
        
        //Display the factors
        Console.Write("Factors of the number are: ");
        for(int i=0;i<answers.Length;i++){
            Console.Write(answers[i]+" ");
        }
        
        Console.WriteLine();
        //sum 
        int sum = Sum(answers);
        
        Console.WriteLine("The Sum of the factors is "+ sum);
        
        //product
        long product = FindProductOfFactors(answers);
        
        Console.WriteLine("The Product of the factors is "+ product);
        
        //square
        double square = FindSumOfSquareOfFactors(answers);
        
        Console.WriteLine("The Sum of the factors is "+ square);
        
    }
    
    static int[] Factors(int number)
    {
        // Count the number of factors
        int count = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
                count++;
        }
        
        // Initialize the array for factors
        int[] factors = new int[count];
        int j = 0;
        
        // Populate the array with factors
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factors[j] = i;
                j++;
            }
        }
        
        return factors;
    }
    
    static int Sum(int [] answers){
        return answers.Sum();
    }
    
    static long FindProductOfFactors(int[] factors)
    {
        long product = 1;
        foreach (int factor in factors)
        {
            product *= factor;
        }
        return product;
    }

   
    static double FindSumOfSquareOfFactors(int[] factors)
    {
        double sumOfSquares = 0;
        foreach (int factor in factors)
        {
            sumOfSquares += Math.Pow(factor, 2);
        }
        return sumOfSquares;
    }
}


