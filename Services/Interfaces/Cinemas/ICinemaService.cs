using Movie_Ticket_Booking_Backend.DTOs.Cinema;

public interface ICinemaService
{
    Task<List<CinemaDto>> GetCinemas();
    Task<CinemaDto?> GetCinema(string id);
    Task<CinemaDto> CreateCinema(CreateCinemaRequest request);
    Task<bool> DeleteCinema(string id);
}