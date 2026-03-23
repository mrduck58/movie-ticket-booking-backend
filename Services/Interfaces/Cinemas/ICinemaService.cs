using Movie_Ticket_Booking_Backend.DTOs.Cinema;

public interface ICinemaService
{
    Task<List<CinemaDto>> GetCinemas();
    Task<CinemaDto?> GetCinemaById(string id);
    Task<List<CinemaListDto>> GetCinemasByMovie(string movieId);
    Task<CinemaDto> CreateCinema(CreateCinemaRequest request);
    Task<bool> DeleteCinema(string id);
}