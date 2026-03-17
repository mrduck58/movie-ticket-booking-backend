using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movie_Ticket_Booking_Backend.Data;

namespace Movie_Ticket_Booking_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MoviesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/movies
        [HttpGet]
        public async Task<IActionResult> GetMovies()
        {
            var movies = await _context.Movies
                .Select(m => new
                {
                    m.MovieId,
                    m.Title,
                    m.Duration,
                    m.Rating,
                    m.Status
                })
                .ToListAsync();

            return Ok(movies);
        }
    }
}