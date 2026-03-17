namespace Movie_Ticket_Booking_Backend.Services.Interfaces
{
    public interface ITicketService
    {
        Task<bool> Checkin(string bookingSeatId);
    }
}
