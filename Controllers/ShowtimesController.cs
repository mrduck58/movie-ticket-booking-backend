using Microsoft.AspNetCore.Mvc;

namespace Movie_Ticket_Booking_Backend.Controllers
{
    public class ShowtimesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
