using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    class Circle
    {
        public double Radius { get; }

        // Default constructor
        public Circle() : this(1.0)  // Calls parameterized constructor with default radius 1.0
        {
        }

        // Parameterized constructor
        public Circle(double radius)
        {
            Radius = radius > 0 ? radius : 1.0; // Ensuring valid radius
        }

        // Method to calculate area
        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public void Display()
        {
            Console.WriteLine($"Circle with Radius: {Radius}, Area: {GetArea()}");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Enter radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Circle userCircle = new Circle(radius);
            userCircle.Display();
        }
    }
}
