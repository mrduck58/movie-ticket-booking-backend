using Microsoft.AspNetCore.Mvc;
using Movie_Ticket_Booking_Backend.DTOs.User;
using Movie_Ticket_Booking_Backend.Services;

namespace Movie_Ticket_Booking_Backend.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterUserRequest dto)
        {
            var user = await _userService.RegisterUser(dto);

            return Ok(new
            {
                message = "Register success",
                userId = user.UserId
            });
        }
    }
}