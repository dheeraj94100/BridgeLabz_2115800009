using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter value of a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter value of b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter value of c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double[] roots = FindRoots(a, b, c);

        if (roots != null)
        {
            Console.WriteLine($"Roots: {roots[0]} and {roots[1]}");
        }
        else
        {
            Console.WriteLine("No real roots");
        }
    }

    static double[] FindRoots(double a, double b, double c)
    {
        double delta = Math.Pow(b, 2) - 4 * a * c;

        if (delta > 0)
        {
            double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return new double[] { root1, root2 };
        }
        else if (delta == 0)
        {
            double root = -b / (2 * a);
            return new double[] { root, root };
        }
        else
        {
            return null; // No real roots
        }
    }
}
