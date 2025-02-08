using System;

// Superclass: Device
class Device
{
    public int DeviceId { get; set; }
    public string Status { get; set; }

    // Constructor to initialize device details
    public Device(int deviceId, string status)
    {
        DeviceId = deviceId;
        Status = status;
    }

    // Method to display device status
    public virtual void DisplayStatus()
    {
        Console.WriteLine($"Device ID: {DeviceId}, Status: {Status}");
    }
}

// Subclass: Thermostat
class Thermostat : Device
{
    public int TemperatureSetting { get; set; }

    // Constructor to initialize thermostat details
    public Thermostat(int deviceId, string status, int temperature)
        : base(deviceId, status)
    {
        TemperatureSetting = temperature;
    }

    // Overriding method to display thermostat status
    public override void DisplayStatus()
    {
        Console.WriteLine($"Thermostat ID: {DeviceId}, Status: {Status}, Temperature: {TemperatureSetting}°C");
    }
}

// Main class to demonstrate functionality
class Program
{
    static void Main()
    {
        // Creating a generic device
        Device genericDevice = new Device(101, "Active");
        genericDevice.DisplayStatus();

        // Creating a thermostat device
        Thermostat smartThermostat = new Thermostat(202, "On", 22);
        smartThermostat.DisplayStatus();
    }
}