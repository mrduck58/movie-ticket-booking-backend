using Movie_Ticket_Booking_Backend.DTOs.Showtime;

public interface IShowtimeService
{
    Task<List<ShowtimeDto>> GetShowtimesByMovie(string movieId);

    Task<ShowtimeDto> CreateShowtime(CreateShowtimeRequest request);
}