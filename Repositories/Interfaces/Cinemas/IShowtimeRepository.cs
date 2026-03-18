using Movie_Ticket_Booking_Backend.Domain.Showtimes;

public interface IShowtimeRepository
{
    Task<List<Showtime>> GetShowtimesByMovie(string movieId);

    Task<List<Showtime>> GetShowtimesByRoom(string roomId);

    Task AddShowtime(Showtime showtime);

    Task Save();
}