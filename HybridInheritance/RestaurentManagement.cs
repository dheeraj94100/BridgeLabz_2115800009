using System;

// Superclass: Person
class Person
{
    public string Name { get; set; }
    public int Id { get; set; }

    // Constructor to initialize common attributes
    public Person(string name, int id)
    {
        Name = name;
        Id = id;
    }

    // Method to display basic details
    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, ID: {Id}");
    }
}

// Interface: Worker
interface Worker
{
    void PerformDuties(); // Method to be implemented by subclasses
}

// Subclass: Chef (Inherits from Person and Implements Worker)
class Chef : Person, Worker
{
    public string Specialty { get; set; }

    // Constructor
    public Chef(string name, int id, string specialty) : base(name, id)
    {
        Specialty = specialty;
    }

    // Implement PerformDuties() from Worker interface
    public void PerformDuties()
    {
        Console.WriteLine($"Chef {Name} is cooking {Specialty} dishes.");
    }

    // Override DisplayDetails()
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Specialty: {Specialty}");
    }
}

// Subclass: Waiter (Inherits from Person and Implements Worker)
class Waiter : Person, Worker
{
    public int TablesAssigned { get; set; }

    // Constructor
    public Waiter(string name, int id, int tablesAssigned) : base(name, id)
    {
        TablesAssigned = tablesAssigned;
    }

    // Implement PerformDuties() from Worker interface
    public void PerformDuties()
    {
        Console.WriteLine($"Waiter {Name} is serving {TablesAssigned} tables.");
    }

    // Override DisplayDetails()
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Tables Assigned: {TablesAssigned}");
    }
}

// Main Class to demonstrate functionality
class Program
{
    static void Main()
    {
        // Creating a Chef object
        Chef chef = new Chef("Vikas Khanna", 101, "Indian Cuisine");
        chef.DisplayDetails();
        chef.PerformDuties();
        
        Console.WriteLine();

        // Creating a Waiter object
        Waiter waiter = new Waiter("Rahul Sharma", 201, 5);
        waiter.DisplayDetails();
        waiter.PerformDuties();
    }
}