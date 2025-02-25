using System;
using System.Data.SqlClient;
using System.IO;

namespace AdvancedProblems
{
    class GenerateCSVReport
    {
        static void Main(string[] args)
        {
            string connectionString = "your_connection_string_here";
            string query = "SELECT EmployeeID, Name, Department, Salary FROM Employees";
            string csvFilePath = "employees.csv";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    using (StreamWriter writer = new StreamWriter(csvFilePath))
                    {
                        // Write CSV headers
                        writer.WriteLine("Employee ID,Name,Department,Salary");

                        // Write CSV rows
                        while (reader.Read())
                        {
                            writer.WriteLine($"{reader["EmployeeID"]},{reader["Name"]},{reader["Department"]},{reader["Salary"]}");
                        }
                    }
                }
                Console.WriteLine("CSV report generated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}