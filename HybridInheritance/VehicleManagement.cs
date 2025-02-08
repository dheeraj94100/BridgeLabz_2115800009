using System;

// Superclass: Vehicle
class Vehicle
{
    public int MaxSpeed { get; set; }
    public string Model { get; set; }

    // Constructor to initialize attributes
    public Vehicle(int maxSpeed, string model)
    {
        MaxSpeed = maxSpeed;
        Model = model;
    }

    // Method to display vehicle information
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Model: {Model}, Max Speed: {MaxSpeed} km/h");
    }
}

// Interface: Refuelable
interface Refuelable
{
    void Refuel(); // Method to be implemented by PetrolVehicle
}

// Subclass: ElectricVehicle (Inherits from Vehicle)
class ElectricVehicle : Vehicle
{
    public int BatteryCapacity { get; set; } // Additional attribute

    // Constructor
    public ElectricVehicle(int maxSpeed, string model, int batteryCapacity) : base(maxSpeed, model)
    {
        BatteryCapacity = batteryCapacity;
    }

    // Method to charge the vehicle
    public void Charge()
    {
        Console.WriteLine($"{Model} is charging. Battery Capacity: {BatteryCapacity} kWh");
    }

    // Override DisplayInfo()
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Battery Capacity: {BatteryCapacity} kWh");
    }
}

// Subclass: PetrolVehicle (Inherits from Vehicle and Implements Refuelable)
class PetrolVehicle : Vehicle, Refuelable
{
    public int FuelCapacity { get; set; } // Additional attribute

    // Constructor
    public PetrolVehicle(int maxSpeed, string model, int fuelCapacity) : base(maxSpeed, model)
    {
        FuelCapacity = fuelCapacity;
    }

    // Implement Refuel() from Refuelable interface
    public void Refuel()
    {
        Console.WriteLine($"{Model} is refueling. Fuel Capacity: {FuelCapacity} liters");
    }

    // Override DisplayInfo()
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Fuel Capacity: {FuelCapacity} liters");
    }
}

// Main Class to demonstrate functionality
class Program
{
    static void Main()
    {
        // Creating an ElectricVehicle object
        ElectricVehicle tesla = new ElectricVehicle(200, "Tesla Model 3", 75);
        tesla.DisplayInfo();
        tesla.Charge();
        
        Console.WriteLine();

        // Creating a PetrolVehicle object
        PetrolVehicle honda = new PetrolVehicle(180, "Honda City", 40);
        honda.DisplayInfo();
        honda.Refuel();
    }
}