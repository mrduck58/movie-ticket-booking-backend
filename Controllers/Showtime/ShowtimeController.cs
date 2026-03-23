using Microsoft.AspNetCore.Mvc;
using Movie_Ticket_Booking_Backend.DTOs.Showtime;

[ApiController]
[Route("api/showtimes")]
public class ShowtimeController : ControllerBase
{
    private readonly IShowtimeService _showtimeService;
    private readonly ISeatService _seatService;

    public ShowtimeController(IShowtimeService showtimeService, ISeatService seatService)
    {
        _showtimeService = showtimeService;
        _seatService = seatService;
    }

    [HttpGet]
    public async Task<IActionResult> GetShowtimes(
    [FromQuery] string movieId,
    [FromQuery] string cinemaId,
    [FromQuery] DateTime date)
    {
        if (string.IsNullOrEmpty(movieId) || string.IsNullOrEmpty(cinemaId))
        {
            return BadRequest("movieId và cinemaId là bắt buộc");
        }

        var result = await _showtimeService
            .GetShowtimes(movieId, cinemaId, date);

        return Ok(result);
    }

    [HttpGet("{showtimeId}/seats")]
    public async Task<IActionResult> GetSeats(string showtimeId)
    {
        var result = await _seatService.GetSeatMapAsync(showtimeId);

        return Ok(result);
    }

    //[HttpGet("movie/{movieId}")]
    //public async Task<IActionResult> GetShowtimes(string movieId)
    //{
    //    var showtimes = await _showtimeService.GetShowtimesByMovie(movieId);

    //    return Ok(showtimes);
    //}

    //[HttpPost]
    //public async Task<IActionResult> CreateShowtime(CreateShowtimeRequest request)
    //{
    //    var showtime = await _showtimeService.CreateShowtime(request);

    //    return Ok(showtime);
    //}
}