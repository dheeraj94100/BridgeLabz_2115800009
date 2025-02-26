using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using Newtonsoft.Json;

namespace HandsOnPracticeProblems
{
    class JSONReportToDatabase
    {
        static void Main(string[] args)
        {
            string connectionString = "your_connection_string_here";
            string query = "SELECT * FROM YourTableName";

            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Dictionary<string, object> row = new Dictionary<string, object>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row[reader.GetName(i)] = reader.GetValue(i);
                    }
                    rows.Add(row);
                }
            }

            string json = JsonConvert.SerializeObject(rows, Formatting.Indented);
            File.WriteAllText("report.json", json);

            Console.WriteLine("JSON report generated successfully.");
        }
    }
}