using System;

namespace Collinear
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sample points A(2, 4), B(4, 6), C(6, 8)
            int x1 = 2, y1 = 4;
            int x2 = 4, y2 = 6;
            int x3 = 6, y3 = 8;

            bool areCollinearBySlope = AreCollinearBySlope(x1, y1, x2, y2, x3, y3);
            bool areCollinearByArea = AreCollinearByArea(x1, y1, x2, y2, x3, y3);

            Console.WriteLine($"Points are collinear by slope method: {areCollinearBySlope}");
            Console.WriteLine($"Points are collinear by area method: {areCollinearByArea}");
        }

        static bool AreCollinearBySlope(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            // Calculate slopes
            double slopeAB = (double)(y2 - y1) / (x2 - x1);
            double slopeBC = (double)(y3 - y2) / (x3 - x2);
            double slopeAC = (double)(y3 - y1) / (x3 - x1);

            // Check if slopes are equal
            return slopeAB == slopeBC && slopeBC == slopeAC;
        }

        static bool AreCollinearByArea(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            // Calculate area of the triangle
            int area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));

            // Check if area is zero
            return area == 0;
        }
    }
}