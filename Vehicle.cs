using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{

    class Vehicle
    {
        public string OwnerName { get; set; }
        public string VehicleType { get; set; }
        public static double RegistrationFee = 5000.0; // Fixed for all vehicles

        // Constructor
        public Vehicle(string ownerName, string vehicleType)
        {
            OwnerName = ownerName;
            VehicleType = vehicleType;
        }

        // Instance Method
        public void DisplayVehicleDetails()
        {
            Console.WriteLine($"Owner: {OwnerName}, Vehicle Type: {VehicleType}, Registration Fee: {RegistrationFee}");
        }

        // Class Method
        public static void UpdateRegistrationFee(double newFee)
        {
            RegistrationFee = newFee;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Enter Owner Name: ");
            string ownerName = Console.ReadLine();
            Console.Write("Enter Vehicle Type: ");
            string vehicleType = Console.ReadLine();

            Vehicle myVehicle = new Vehicle(ownerName, vehicleType);
            myVehicle.DisplayVehicleDetails();

            Console.Write("Enter new Registration Fee: ");
            double newFee = Convert.ToDouble(Console.ReadLine());
            Vehicle.UpdateRegistrationFee(newFee);

            Console.WriteLine($"Updated Registration Fee: {Vehicle.RegistrationFee}");
        }
    }
}