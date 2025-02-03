using System;

class Patient
{
    private static string HospitalName = "City Care Hospital";  // Static variable shared by all patients
    private static int TotalPatients = 0;  // Static counter for total patients

    public readonly int PatientID;  // Readonly variable (cannot change after assignment)
    public string Name;
    public int Age;
    public string Ailment;

    // Constructor using 'this' to initialize properties
    public Patient(string Name, int Age, string Ailment)
    {
        this.PatientID = ++TotalPatients;  // Auto-increment unique ID
        this.Name = Name;
        this.Age = Age;
        this.Ailment = Ailment;
    }

    // Static method to get the total number of patients
    public static void GetTotalPatients()
    {
        Console.WriteLine($"Total Patients Admitted: {TotalPatients}");
    }

    // Display patient details using 'is' operator for type checking
    public void DisplayPatientInfo()
    {
        if (this is Patient)  // Checking if object is an instance of Patient
        {
            Console.WriteLine("\n--- Patient Details ---");
            Console.WriteLine($"Hospital: {HospitalName}");
            Console.WriteLine($"Patient ID: {PatientID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Ailment: {Ailment}\n");
        }
        else
        {
            Console.WriteLine("Invalid patient record!");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of patients to admit: ");
        int patientCount = Convert.ToInt32(Console.ReadLine());

        Patient[] patients = new Patient[patientCount];

        for (int i = 0; i < patientCount; i++)
        {
            Console.WriteLine($"\nEnter details for Patient {i + 1}:");

            Console.Write("Enter Patient Name: ");
            string name = Convert.ToString(Console.ReadLine());

            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Ailment: ");
            string ailment = Convert.ToString(Console.ReadLine());

            patients[i] = new Patient(name, age, ailment);
        }

        // Display all patient details
        Console.WriteLine("\nAll Admitted Patients:");
        foreach (Patient patient in patients)
        {
            patient.DisplayPatientInfo();
        }

        // Display total patients count
        Patient.GetTotalPatients();
    }
}
