using Microsoft.AspNetCore.Mvc;

namespace Movie_Ticket_Booking_Backend.Controllers.Showtime
{
    public class ShowtimeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
