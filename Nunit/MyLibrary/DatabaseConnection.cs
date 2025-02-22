using System;

namespace MyLibrary
{
    public class DatabaseConnection
    {
        public bool IsConnected { get; private set; }

        public void Connect()
        {
            IsConnected = true;
            Console.WriteLine("Database Connected.");
        }

        public void Disconnect()
        {
            IsConnected = false;
            Console.WriteLine("Database Disconnected.");
        }
    }
}
