using Microsoft.AspNetCore.Mvc;

namespace Movie_Ticket_Booking_Backend.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
