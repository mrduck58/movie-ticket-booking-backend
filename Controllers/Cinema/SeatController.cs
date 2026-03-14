using Microsoft.AspNetCore.Mvc;

namespace Movie_Ticket_Booking_Backend.Controllers.Cinema
{
    public class SeatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
