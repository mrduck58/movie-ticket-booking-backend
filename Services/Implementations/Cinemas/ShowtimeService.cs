using Movie_Ticket_Booking_Backend.Domain.Showtimes;
using Movie_Ticket_Booking_Backend.DTOs.Showtime;

public class ShowtimeService : IShowtimeService
{
    private readonly IShowtimeRepository _showtimeRepository;

    public ShowtimeService(IShowtimeRepository showtimeRepository)
    {
        _showtimeRepository = showtimeRepository;
    }

    public async Task<List<ShowtimeDto>> GetShowtimesByMovie(string movieId)
    {
        var showtimes = await _showtimeRepository.GetShowtimesByMovie(movieId);

        return showtimes.Select(x => new ShowtimeDto
        {
            ShowtimeId = x.ShowtimeId,
            MovieId = x.MovieId,
            RoomId = x.RoomId,
            StartTime = x.StartTime,
            EndTime = x.EndTime
        }).ToList();
    }

    public async Task<ShowtimeDto> CreateShowtime(CreateShowtimeRequest request)
    {
        var showtime = new Showtime
        {
            MovieId = request.MovieId,
            RoomId = request.RoomId,
            StartTime = request.StartTime,
            EndTime = request.EndTime
        };

        await _showtimeRepository.AddShowtime(showtime);

        await _showtimeRepository.Save();

        return new ShowtimeDto
        {
            ShowtimeId = showtime.ShowtimeId,
            MovieId = showtime.MovieId,
            RoomId = showtime.RoomId,
            StartTime = showtime.StartTime,
            EndTime = showtime.EndTime
        };
    }
}