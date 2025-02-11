using System;

public class Ticket
{
    public int TicketID { get; set; }
    public string CustomerName { get; set; }
    public string MovieName { get; set; }
    public string SeatNumber { get; set; }
    public DateTime BookingTime { get; set; }
    public Ticket Next { get; set; }
}

public class TicketReservationSystem
{
    private Ticket head;

    public TicketReservationSystem()
    {
        head = null;
    }

    public void AddTicket(int ticketID, string customerName, string movieName, string seatNumber, DateTime bookingTime)
    {
        Ticket newTicket = new Ticket
        {
            TicketID = ticketID,
            CustomerName = customerName,
            MovieName = movieName,
            SeatNumber = seatNumber,
            BookingTime = bookingTime,
            Next = head
        };

        if (head == null)
        {
            head = newTicket;
            head.Next = head;
        }
        else
        {
            Ticket temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }
            temp.Next = newTicket;
        }
    }

    public void RemoveTicket(int ticketID)
    {
        if (head == null) return;

        if (head.TicketID == ticketID)
        {
            if (head.Next == head)
            {
                head = null;
            }
            else
            {
                Ticket temp = head;
                while (temp.Next != head)
                {
                    temp = temp.Next;
                }
                temp.Next = head.Next;
                head = head.Next;
            }
            return;
        }

        Ticket current = head;
        Ticket previous = null;
        do
        {
            previous = current;
            current = current.Next;
            if (current.TicketID == ticketID)
            {
                previous.Next = current.Next;
                return;
            }
        } while (current != head);
    }

    public void DisplayTickets()
    {
        if (head == null)
        {
            Console.WriteLine("No tickets booked.");
            return;
        }

        Ticket temp = head;
        do
        {
            Console.WriteLine($"TicketID: {temp.TicketID}, CustomerName: {temp.CustomerName}, MovieName: {temp.MovieName}, SeatNumber: {temp.SeatNumber}, BookingTime: {temp.BookingTime}");
            temp = temp.Next;
        } while (temp != head);
    }

    public void SearchTicket(string searchTerm)
    {
        if (head == null)
        {
            Console.WriteLine("No tickets booked.");
            return;
        }

        Ticket temp = head;
        bool found = false;
        do
        {
            if (temp.CustomerName.Equals(searchTerm, StringComparison.OrdinalIgnoreCase) || temp.MovieName.Equals(searchTerm, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"TicketID: {temp.TicketID}, CustomerName: {temp.CustomerName}, MovieName: {temp.MovieName}, SeatNumber: {temp.SeatNumber}, BookingTime: {temp.BookingTime}");
                found = true;
            }
            temp = temp.Next;
        } while (temp != head);

        if (!found)
        {
            Console.WriteLine("No matching tickets found.");
        }
    }

    public int TotalTickets()
    {
        if (head == null) return 0;

        int count = 0;
        Ticket temp = head;
        do
        {
            count++;
            temp = temp.Next;
        } while (temp != head);

        return count;
    }

    public static void Main(string[] args)
    {
        TicketReservationSystem system = new TicketReservationSystem();

        system.AddTicket(1, "John Doe", "Movie A", "A1", DateTime.Now);
        system.AddTicket(2, "Jane Smith", "Movie B", "B2", DateTime.Now);
        system.AddTicket(3, "Alice Johnson", "Movie A", "A2", DateTime.Now);

        Console.WriteLine("Current Tickets:");
        system.DisplayTickets();

        Console.WriteLine("\nSearching for tickets by Customer Name 'John Doe':");
        system.SearchTicket("John Doe");

        Console.WriteLine("\nTotal Tickets Booked: " + system.TotalTickets());

        Console.WriteLine("\nRemoving Ticket with ID 2");
        system.RemoveTicket(2);

        Console.WriteLine("\nCurrent Tickets:");
        system.DisplayTickets();

        Console.WriteLine("\nTotal Tickets Booked: " + system.TotalTickets());
    }
}