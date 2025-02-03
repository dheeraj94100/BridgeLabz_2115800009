using System;
<<<<<<< HEAD
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
=======

class Vehicle
{
    private static double RegistrationFee = 5000;  // Static variable shared by all vehicles
    public static void UpdateRegistrationFee(double newFee)  // Static method to update fee
    {
        RegistrationFee = newFee;
        Console.WriteLine($"Updated Registration Fee: {RegistrationFee}");
    }

    public readonly string RegistrationNumber;  // Readonly variable (cannot change after assignment)
    public string OwnerName;
    public string VehicleType;

    // Constructor using 'this' to initialize properties
    public Vehicle(string OwnerName, string VehicleType, string RegistrationNumber)
    {
        this.OwnerName = OwnerName;
        this.VehicleType = VehicleType;
        this.RegistrationNumber = RegistrationNumber;
    }

    // Display vehicle details using 'is' operator for type checking
    public void DisplayVehicleInfo()
    {
        if (this is Vehicle)  // Checking if object is an instance of Vehicle
        {
            Console.WriteLine("\n--- Vehicle Registration Details ---");
            Console.WriteLine($"Owner: {OwnerName}");
            Console.WriteLine($"Vehicle Type: {VehicleType}");
            Console.WriteLine($"Registration Number: {RegistrationNumber}");
            Console.WriteLine($"Registration Fee: {RegistrationFee}\n");
        }
        else
        {
            Console.WriteLine("Invalid vehicle record!");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of vehicles to register: ");
        int vehicleCount = Convert.ToInt32(Console.ReadLine());

        Vehicle[] vehicles = new Vehicle[vehicleCount];

        for (int i = 0; i < vehicleCount; i++)
        {
            Console.WriteLine($"\nEnter details for Vehicle {i + 1}:");

            Console.Write("Enter Owner Name: ");
            string ownerName = Convert.ToString(Console.ReadLine());

            Console.Write("Enter Vehicle Type (Car/Bike/Truck): ");
            string vehicleType = Convert.ToString(Console.ReadLine());

            Console.Write("Enter Registration Number: ");
            string registrationNumber = Convert.ToString(Console.ReadLine());

            vehicles[i] = new Vehicle(ownerName, vehicleType, registrationNumber);
        }

        // Display all vehicle details
        Console.WriteLine("\nAll Registered Vehicles:");
        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.DisplayVehicleInfo();
        }

        // Option to update the registration fee
        Console.Write("\nDo you want to update the registration fee? (yes/no): ");
        string response = Convert.ToString(Console.ReadLine());

        if (response.ToLower() == "yes")
        {
            Console.Write("Enter new registration fee: ");
            double newFee = Convert.ToDouble(Console.ReadLine());
            Vehicle.UpdateRegistrationFee(newFee);
        }
    }
}
>>>>>>> 32cfaf8c574052612043f6bc65b30cba3343b263
