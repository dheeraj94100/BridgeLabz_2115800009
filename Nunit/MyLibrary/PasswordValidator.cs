using System;
using System.Text.RegularExpressions;

namespace MyLibrary
{
    public class PasswordValidator
    {
        public bool IsValidPassword(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 8)
                return false;
            if (!Regex.IsMatch(password, @"[A-Z]"))
                return false;
            if (!Regex.IsMatch(password, @"\d"))
                return false;
            return true;
        }
    }
}
