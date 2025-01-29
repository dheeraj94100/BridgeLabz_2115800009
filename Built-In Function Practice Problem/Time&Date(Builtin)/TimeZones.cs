using System;

class TimeZoneConverter
{
    static void Main()
    {
        // Get the current UTC time
        DateTimeOffset utcNow = DateTimeOffset.UtcNow;

        // Convert to different time zones
        DateTimeOffset gmtTime = utcNow; // GMT is same as UTC
        DateTimeOffset istTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(utcNow, "India Standard Time");
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(utcNow, "Pacific Standard Time");

        // Display results
        Console.WriteLine("Current Time in Different Time Zones:");
        Console.WriteLine($"GMT (Greenwich Mean Time): {gmtTime:yyyy-MM-dd HH:mm:ss} UTC");
        Console.WriteLine($"IST (Indian Standard Time): {istTime:yyyy-MM-dd HH:mm:ss} IST");
        Console.WriteLine($"PST (Pacific Standard Time): {pstTime:yyyy-MM-dd HH:mm:ss} PST");
    }
}