using Microsoft.AspNetCore.Mvc;
using Movie_Ticket_Booking_Backend.DTOs.Showtime;

[ApiController]
[Route("api/showtimes")]
public class ShowtimeController : ControllerBase
{
    private readonly IShowtimeService _showtimeService;

    public ShowtimeController(IShowtimeService showtimeService)
    {
        _showtimeService = showtimeService;
    }

    [HttpGet("movie/{movieId}")]
    public async Task<IActionResult> GetShowtimes(string movieId)
    {
        var showtimes = await _showtimeService.GetShowtimesByMovie(movieId);

        return Ok(showtimes);
    }

    [HttpPost]
    public async Task<IActionResult> CreateShowtime(CreateShowtimeRequest request)
    {
        var showtime = await _showtimeService.CreateShowtime(request);

        return Ok(showtime);
    }
}