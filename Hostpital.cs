using System;
using System.Collections.Generic;

// Abstract class Patient
abstract class Patient
{
    private string patientId;
    private string name;
    private int age;
    protected string diagnosis;
    protected List<string> medicalHistory = new List<string>();

    public Patient(string patientId, string name, int age)
    {
        this.patientId = patientId;
        this.name = name;
        this.age = age;
    }

    public string PatientId { get { return patientId; } }
    public string Name { get { return name; } }
    public int Age { get { return age; } }

    public abstract double CalculateBill();

    public virtual void GetPatientDetails()
    {
        Console.WriteLine($"Patient ID: {PatientId}, Name: {Name}, Age: {Age}");
    }
}

// Interface for medical records
interface IMedicalRecord
{
    void AddRecord(string record);
    void ViewRecords();
}

// InPatient class
class InPatient : Patient, IMedicalRecord
{
    private double dailyCharge;
    private int daysAdmitted;

    public InPatient(string patientId, string name, int age, double dailyCharge, int daysAdmitted)
        : base(patientId, name, age)
    {
        this.dailyCharge = dailyCharge;
        this.daysAdmitted = daysAdmitted;
    }

    public override double CalculateBill()
    {
        return dailyCharge * daysAdmitted;
    }

    public void AddRecord(string record)
    {
        medicalHistory.Add(record);
    }

    public void ViewRecords()
    {
        Console.WriteLine($"Medical Records for {Name}:");
        foreach (var record in medicalHistory)
        {
            Console.WriteLine(record);
        }
    }
}

// OutPatient class
class OutPatient : Patient, IMedicalRecord
{
    private double consultationFee;

    public OutPatient(string patientId, string name, int age, double consultationFee)
        : base(patientId, name, age)
    {
        this.consultationFee = consultationFee;
    }

    public override double CalculateBill()
    {
        return consultationFee;
    }

    public void AddRecord(string record)
    {
        medicalHistory.Add(record);
    }

    public void ViewRecords()
    {
        Console.WriteLine($"Medical Records for {Name}:");
        foreach (var record in medicalHistory)
        {
            Console.WriteLine(record);
        }
    }
}

class Program
{
    static void Main()
    {
        List<Patient> patients = new List<Patient>();

        Console.Write("Enter number of patients: ");
        int numPatients = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numPatients; i++)
        {
            Console.WriteLine("\nEnter details for Patient " + (i + 1));
            Console.Write("Enter Patient ID: ");
            string id = Console.ReadLine();

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Patient Type (InPatient/OutPatient): ");
            string type = Console.ReadLine().ToLower();

            if (type == "inpatient")
            {
                Console.Write("Enter Daily Charge: ");
                double dailyCharge = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Days Admitted: ");
                int daysAdmitted = Convert.ToInt32(Console.ReadLine());

                patients.Add(new InPatient(id, name, age, dailyCharge, daysAdmitted));
            }
            else if (type == "outpatient")
            {
                Console.Write("Enter Consultation Fee: ");
                double consultationFee = Convert.ToDouble(Console.ReadLine());

                patients.Add(new OutPatient(id, name, age, consultationFee));
            }
            else
            {
                Console.WriteLine("Invalid Patient Type. Skipping entry.");
            }
        }

        Console.WriteLine("\nPatient Billing Details:");
        foreach (var patient in patients)
        {
            patient.GetPatientDetails();
            Console.WriteLine($"Total Bill: {patient.CalculateBill():C}");

            if (patient is IMedicalRecord recordable)
            {
                Console.Write("Enter Medical Record for " + patient.Name + ": ");
                string record = Console.ReadLine();
                recordable.AddRecord(record);
                recordable.ViewRecords();
            }
            Console.WriteLine();
        }
    }
}