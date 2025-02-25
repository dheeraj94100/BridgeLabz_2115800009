using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;
using System.Linq;

class Program
{
    private static readonly string encryptionKey = "ThisIsASecretKey"; // 16, 24, or 32 chars for AES

    static void Main()
    {
        string filePath = "Encrypt.csv";

        // Sample data
        List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "John Doe", Email = "john.doe@example.com", Salary = "50000" },
            new Employee { Name = "Jane Smith", Email = "jane.smith@example.com", Salary = "60000" }
        };

        // Encrypt and write to CSV
        WriteEncryptedCsv(filePath, employees);
        Console.WriteLine("Encrypted CSV written successfully.");

        // Read and decrypt CSV
        List<Employee> decryptedEmployees = ReadDecryptedCsv(filePath);
        Console.WriteLine("\nDecrypted CSV Data:");
        foreach (var emp in decryptedEmployees)
        {
            Console.WriteLine($"Name: {emp.Name}, Salary: {emp.Salary}, Email: {emp.Email}");
        }
    }

    static void WriteEncryptedCsv(string filePath, List<Employee> employees)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Name,Salary,Email"); // Header

            foreach (var emp in employees)
            {
                string encryptedEmail = Encrypt(emp.Email);
                string encryptedSalary = Encrypt(emp.Salary);

                writer.WriteLine($"{emp.Name},{encryptedSalary},{encryptedEmail}");
            }
        }
    }

    static List<Employee> ReadDecryptedCsv(string filePath)
    {
        List<Employee> employees = new List<Employee>();

        using (StreamReader reader = new StreamReader(filePath))
        {
            string? headerLine = reader.ReadLine(); // Read header

            while (!reader.EndOfStream)
            {
                string? line = reader.ReadLine();
                if (string.IsNullOrEmpty(line)) continue; // Avoid null reference errors

                string[] values = line.Split(',');

                if (values.Length == 3)
                {
                    employees.Add(new Employee
                    {
                        Name = values[0] ?? "Unknown", // Null check
                        Salary = Decrypt(values[1]) ?? "0"
                        Email = Decrypt(values[2]) ?? "Unknown",
                    });
                }
            }
        }

        return employees;
    }

    static string Encrypt(string plainText)
    {
        if (string.IsNullOrEmpty(plainText)) return string.Empty;

        using (Aes aes = Aes.Create())
        {
            aes.Key = Encoding.UTF8.GetBytes(encryptionKey.PadRight(32).Substring(0, 32));
            aes.IV = new byte[16]; // Default IV (for simplicity)

            using (MemoryStream ms = new MemoryStream()) // Fix: Ensure ms exists
            using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
            using (StreamWriter sw = new StreamWriter(cs))
            {
                sw.Write(plainText);
                sw.Flush(); // Ensure data is written
                cs.FlushFinalBlock(); // Ensure encryption completes
                return Convert.ToBase64String(ms.ToArray());
            }
        }
    }

    static string Decrypt(string cipherText)
    {
        if (string.IsNullOrEmpty(cipherText)) return string.Empty;

        using (Aes aes = Aes.Create())
        {
            aes.Key = Encoding.UTF8.GetBytes(encryptionKey.PadRight(32).Substring(0, 32));
            aes.IV = new byte[16]; // Default IV (must match encryption)

            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(cipherText)))
            using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read))
            using (StreamReader sr = new StreamReader(cs))
            {
                return sr.ReadToEnd();
            }
        }
    }

    class Employee
    {
        public string Name { get; set; } = "Unknown";  // Fix: Initialize properties
        public string Email { get; set; } = "Unknown";
        public string Salary { get; set; } = "0";

        public Employee() { } // Fix: Default constructor
    }
}