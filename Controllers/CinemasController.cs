using Microsoft.AspNetCore.Mvc;

namespace Movie_Ticket_Booking_Backend.Controllers
{
    public class CinemasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
