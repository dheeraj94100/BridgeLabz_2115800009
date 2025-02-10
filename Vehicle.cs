using System;
using System.Collections.Generic;

// Abstract class Vehicle
abstract class Vehicle
{
    private string vehicleNumber;
    private string type;
    private double rentalRate;

    public Vehicle(string number, string type, double rate)
    {
        this.vehicleNumber = number;
        this.type = type;
        this.rentalRate = rate;
    }

    public string VehicleNumber { get { return vehicleNumber; } }
    public string Type { get { return type; } }
    public double RentalRate { get { return rentalRate; } }

    public abstract double CalculateRentalCost(int days);

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Vehicle Number: {VehicleNumber}, Type: {Type}, Rental Rate: {RentalRate:C}");
    }
}

// Interface for insurance
interface IInsurable
{
    double CalculateInsurance();
    string GetInsuranceDetails();
}

// Car subclass
class Car : Vehicle, IInsurable
{
    public Car(string number, double rate) : base(number, "Car", rate) { }

    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days;
    }

    public double CalculateInsurance()
    {
        return RentalRate * 0.10;
    }

    public string GetInsuranceDetails()
    {
        return "Car Insurance: 10% of rental cost";
    }
}

// Bike subclass
class Bike : Vehicle
{
    public Bike(string number, double rate) : base(number, "Bike", rate) { }

    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days * 0.9; // 10% discount
    }
}

// Truck subclass
class Truck : Vehicle, IInsurable
{
    public Truck(string number, double rate) : base(number, "Truck", rate) { }

    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days * 1.2; // 20% surcharge
    }

    public double CalculateInsurance()
    {
        return RentalRate * 0.15;
    }

    public string GetInsuranceDetails()
    {
        return "Truck Insurance: 15% of rental cost";
    }
}

class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>();

        Console.Write("Enter number of vehicles: ");
        int numVehicles = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numVehicles; i++)
        {
            Console.WriteLine("\nEnter details for Vehicle " + (i + 1));
            Console.Write("Enter Vehicle Number: ");
            string number = Console.ReadLine();

            Console.Write("Enter Rental Rate per Day: ");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Vehicle Type (Car/Bike/Truck): ");
            string type = Console.ReadLine().ToLower();

            if (type == "car")
            {
                vehicles.Add(new Car(number, rate));
            }
            else if (type == "bike")
            {
                vehicles.Add(new Bike(number, rate));
            }
            else if (type == "truck")
            {
                vehicles.Add(new Truck(number, rate));
            }
            else
            {
                Console.WriteLine("Invalid Vehicle Type. Skipping entry.");
            }
        }

        Console.Write("\nEnter rental period (in days): ");
        int days = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nVehicle Rental Details:");
        foreach (var vehicle in vehicles)
        {
            vehicle.DisplayDetails();
            Console.WriteLine($"Rental Cost for {days} days: {vehicle.CalculateRentalCost(days):C}");

            if (vehicle is IInsurable insurable)
            {
                Console.WriteLine(insurable.GetInsuranceDetails());
                Console.WriteLine($"Insurance Cost: {insurable.CalculateInsurance():C}");
            }
            Console.WriteLine();
        }
    }
}
