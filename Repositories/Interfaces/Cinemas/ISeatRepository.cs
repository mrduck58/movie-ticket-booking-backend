using Movie_Ticket_Booking_Backend.Domain.Cinemas;

namespace Movie_Ticket_Booking_Backend.Repositories.Interfaces.Cinemas
{
    public interface ISeatRepository
    {
        Task<List<Seat>> GetSeatsByRoom(string roomId);
        Task<List<Seat>> GetSeatsByShowtime(string showtimeId);
        Task<Seat?> GetSeat(string seatId);
        Task AddSeat(Seat seat);
        void UpdateSeat(Seat seat);
        Task Save();
    }
}
