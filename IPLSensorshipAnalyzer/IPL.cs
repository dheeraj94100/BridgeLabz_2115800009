using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace IPLSensorshipAnalyzer
{
    public class Match
    {
        public int MatchId { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public Dictionary<string, int> Score { get; set; }
        public string Winner { get; set; }
        public string PlayerOfMatch { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string jsonInputPath = "json_input.json";
            string csvInputPath = "csv_input.csv";
            string jsonOutputPath = "json_output.json";
            string csvOutputPath = "csv_output.csv";

            List<Match> matches = new List<Match>();

            // Read JSON input
            if (File.Exists(jsonInputPath))
            {
                string jsonData = File.ReadAllText(jsonInputPath);
                matches = JsonConvert.DeserializeObject<List<Match>>(jsonData);
            }

            // Read CSV input
            if (File.Exists(csvInputPath))
            {
                using (var reader = new StreamReader(csvInputPath))
                using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    matches.AddRange(csv.GetRecords<Match>());
                }
            }

            // Apply censorship rules
            foreach (var match in matches)
            {
                match.Team1 = MaskTeamName(match.Team1);
                match.Team2 = MaskTeamName(match.Team2);
                match.Winner = MaskTeamName(match.Winner);
                match.PlayerOfMatch = "REDACTED";

                var newScore = new Dictionary<string, int>();
                foreach (var score in match.Score)
                {
                    newScore[MaskTeamName(score.Key)] = score.Value;
                }
                match.Score = newScore;
            }

            // Write JSON output
            string jsonOutput = JsonConvert.SerializeObject(matches, Formatting.Indented);
            File.WriteAllText(jsonOutputPath, jsonOutput);

            // Write CSV output
            using (var writer = new StreamWriter(csvOutputPath))
            using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                csv.WriteRecords(matches);
            }
        }

        static string MaskTeamName(string teamName)
        {
            var parts = teamName.Split(' ');
            if (parts.Length > 1)
            {
                parts[1] = "***";
                return string.Join(' ', parts);
            }
            return teamName;
        }
    }
}