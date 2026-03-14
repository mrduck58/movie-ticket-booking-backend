using Microsoft.AspNetCore.Mvc;

namespace Movie_Ticket_Booking_Backend.Controllers.Blog
{
    public class BlogPostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
