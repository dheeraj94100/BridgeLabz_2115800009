using System;

namespace MyLibrary
{
    public class DateFormatter
    {
        public string FormatDate(string inputDate)
        {
            if (DateTime.TryParse(inputDate, out DateTime date))
            {
                return date.ToString("dd-MM-yyyy");
            }
            throw new FormatException("Invalid date format.");
        }
    }
}
