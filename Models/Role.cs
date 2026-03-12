namespace Movie_Ticket_Booking_Backend.Models;

public class Role
{
    public int Id { get; set; }

    public string Name { get; set; }

    public ICollection<User> Users { get; set; }
}

