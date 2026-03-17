using Microsoft.AspNetCore.Mvc;
using Movie_Ticket_Booking_Backend.DTOs.Movie;
using Movie_Ticket_Booking_Backend.Services.Interfaces.Movies;

namespace Movie_Ticket_Booking_Backend.Controllers.Movie
{
    [ApiController]
    [Route("api/watchlist")]
    public class WatchListController : ControllerBase
    {
        private readonly IWatchListService _service;

        public WatchListController(IWatchListService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddWatchListDto dto)
        {
            try
            {
                await _service.AddAsync(dto);
                return Ok("Added to watchlist");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> Get(string userId)
        {
            var result = await _service.GetUserWatchList(userId);
            if (result == null || !result.Any())
            {
                return NotFound("Watchlist not found");
            }
            return Ok(result);
        }

        [HttpDelete("{userId}/{movieId}")]
        public async Task<IActionResult> Remove(string userId, string movieId)
        {
            try
            {
                await _service.RemoveAsync(userId, movieId);
                return Ok(new { message = "Removed from watchlist" });
            }
            catch
            {
                return NotFound(new { message = "Watchlist item not found" });
            }
        }
    }
}
