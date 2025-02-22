using System;
using System.Text.RegularExpressions;

namespace MyLibrary
{
    public class UserRegistration
    {
        public void RegisterUser(string username, string email, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                throw new ArgumentException("Fields cannot be empty.");

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                throw new ArgumentException("Invalid email format.");
        }
    }
}
