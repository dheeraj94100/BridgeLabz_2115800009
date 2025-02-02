using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    class HotelBooking
    {
        public string GuestName { get; }
        public string RoomType { get; }
        public int Nights { get; }

        // Parameterized Constructor
        public HotelBooking(string guestName, string roomType, int nights)
        {
            GuestName = guestName;
            RoomType = roomType;
            Nights = nights;
        }

        // Copy Constructor
        public HotelBooking(HotelBooking other)
        {
            GuestName = other.GuestName;
            RoomType = other.RoomType;
            Nights = other.Nights;
        }

        public void DisplayBooking()
        {
            Console.WriteLine($"Guest: {GuestName}, Room Type: {RoomType}, Nights: {Nights}");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Enter Guest Name: ");
            string guestName = Console.ReadLine();

            Console.Write("Enter Room Type: ");
            string roomType = Console.ReadLine();

            Console.Write("Enter Number of Nights: ");
            int nights = Convert.ToInt32(Console.ReadLine());

            HotelBooking booking1 = new HotelBooking(guestName, roomType, nights);
            booking1.DisplayBooking();

            HotelBooking booking2 = new HotelBooking(booking1);  // Copy booking
            booking2.DisplayBooking();
        }
    }
}
