using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    class CarRental
    {
        public string CustomerName { get; }
        public string CarModel { get; }
        public int RentalDays { get; }
        private double TotalCost;

        // Constructor
        public CarRental(string customerName, string carModel, int rentalDays)
        {
            CustomerName = customerName;
            CarModel = carModel;
            RentalDays = rentalDays;
            TotalCost = CalculateCost();
        }

        // Method to calculate cost
        private double CalculateCost()
        {
            double ratePerDay = 50.0;  // Assume $50 per day
            return RentalDays * ratePerDay;
        }

        public void DisplayRental()
        {
            Console.WriteLine($"Customer: {CustomerName}, Car Model: {CarModel}, Rental Days: {RentalDays}, Total Cost: ${TotalCost}");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Enter Customer Name: ");
            string customerName = Console.ReadLine();

            Console.Write("Enter Car Model: ");
            string carModel = Console.ReadLine();

            Console.Write("Enter Number of Rental Days: ");
            int rentalDays = Convert.ToInt32(Console.ReadLine());

            CarRental rental = new CarRental(customerName, carModel, rentalDays);
            rental.DisplayRental();
        }
    }
}
