using System;
using System.Collections.Generic;

// Abstract class Vehicle
abstract class Vehicle
{
    private string vehicleId;
    private string driverName;
    protected double ratePerKm;

    public Vehicle(string vehicleId, string driverName, double ratePerKm)
    {
        this.vehicleId = vehicleId;
        this.driverName = driverName;
        this.ratePerKm = ratePerKm;
    }

    public string VehicleId { get { return vehicleId; } }
    public string DriverName { get { return driverName; } }

    public abstract double CalculateFare(double distance);

    public virtual void GetVehicleDetails()
    {
        Console.WriteLine($"Vehicle ID: {VehicleId}, Driver: {DriverName}, Rate per Km: {ratePerKm}");
    }
}

// Interface for GPS tracking
interface IGPS
{
    string GetCurrentLocation();
    void UpdateLocation(string newLocation);
}

// Car class
class Car : Vehicle, IGPS
{
    public Car(string vehicleId, string driverName, double ratePerKm)
        : base(vehicleId, driverName, ratePerKm) { }

    public override double CalculateFare(double distance)
    {
        return ratePerKm * distance;
    }

    public string GetCurrentLocation()
    {
        return "Car location: Downtown";
    }

    public void UpdateLocation(string newLocation)
    {
        Console.WriteLine($"Car location updated to: {newLocation}");
    }
}

// Bike class
class Bike : Vehicle, IGPS
{
    public Bike(string vehicleId, string driverName, double ratePerKm)
        : base(vehicleId, driverName, ratePerKm) { }

    public override double CalculateFare(double distance)
    {
        return ratePerKm * distance * 0.9; // Discounted rate for bikes
    }

    public string GetCurrentLocation()
    {
        return "Bike location: City Park";
    }

    public void UpdateLocation(string newLocation)
    {
        Console.WriteLine($"Bike location updated to: {newLocation}");
    }
}

// Auto class
class Auto : Vehicle, IGPS
{
    public Auto(string vehicleId, string driverName, double ratePerKm)
        : base(vehicleId, driverName, ratePerKm) { }

    public override double CalculateFare(double distance)
    {
        return ratePerKm * distance * 1.1; // Slightly higher rate for autos
    }

    public string GetCurrentLocation()
    {
        return "Auto location: Market Square";
    }

    public void UpdateLocation(string newLocation)
    {
        Console.WriteLine($"Auto location updated to: {newLocation}");
    }
}

class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("C101", "John Doe", 10),
            new Bike("B202", "Jane Smith", 5),
            new Auto("A303", "Robert Brown", 7)
        };

        Console.Write("Enter distance to travel (in km): ");
        double distance = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nRide Fare Details:");
        foreach (var vehicle in vehicles)
        {
            vehicle.GetVehicleDetails();
            Console.WriteLine($"Estimated Fare: {vehicle.CalculateFare(distance):C}");

            if (vehicle is IGPS gpsEnabled)
            {
                Console.WriteLine(gpsEnabled.GetCurrentLocation());
                gpsEnabled.UpdateLocation("New Destination");
            }
            Console.WriteLine();
        }
    }
}
