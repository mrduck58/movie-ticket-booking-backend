using Microsoft.AspNetCore.Mvc;
using Movie_Ticket_Booking_Backend.DTOs.Movie;
using Movie_Ticket_Booking_Backend.Services.Interfaces.Movies;

[ApiController]
[Route("api/movies")]
public class MovieController : ControllerBase
{
    private readonly IMovieService _movieService;
    private readonly ICinemaService _cinemaService;

    public MovieController(IMovieService movieService, ICinemaService cinemaService)
    {
        _movieService = movieService;
        _cinemaService = cinemaService;
    }

    [HttpGet]
    public async Task<IActionResult> GetMovies()
    {
        var movies = await _movieService.GetMovies();

        return Ok(movies);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetMovie(string id)
    {
        var movie = await _movieService.GetMovie(id);

        if (movie == null)
            return NotFound();

        return Ok(movie);
    }

    [HttpGet("{movieId}/cinemas")]
    public async Task<IActionResult> GetCinemasByMovie(string movieId)
    {
        var result = await _cinemaService.GetCinemasByMovie(movieId);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> CreateMovie(CreateMovieRequest request)
    {
        var movie = await _movieService.CreateMovie(request);

        return Ok(movie);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteMovie(string id)
    {
        var result = await _movieService.DeleteMovie(id);

        if (!result)
            return NotFound();

        return Ok();
    }
}