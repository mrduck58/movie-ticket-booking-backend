using Microsoft.AspNetCore.Mvc;
using Movie_Ticket_Booking_Backend.Domain.Movies;

[ApiController]
[Route("api/cinemas")]
public class CinemaController : ControllerBase
{
    private readonly ICinemaService _cinemaService;

    public CinemaController(ICinemaService cinemaService)
    {
        _cinemaService = cinemaService;
    }

    [HttpGet]
    public async Task<IActionResult> GetCinemas()
    {
        var cinemas = await _cinemaService.GetCinemas();

        return Ok(cinemas);
    }

    [HttpGet("{cinemaId}")]
    public async Task<IActionResult> GetCinemaById(string cinemaId)
    {
        var cinema = await _cinemaService.GetCinemaById(cinemaId);

        if (cinema == null)
            return NotFound();

        return Ok(cinema);
    }

    //[HttpGet("movies/{movieId}/cinemas")]
    //public async Task<IActionResult> GetCinemasByMovie(string movieId)
    //{
    //    var result = await _cinemaService.GetCinemasByMovie(movieId);
    //    return Ok(result);
    //}
}