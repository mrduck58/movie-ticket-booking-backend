using Microsoft.AspNetCore.Mvc;
using Movie_Ticket_Booking_Backend.DTOs;
using Movie_Ticket_Booking_Backend.DTOs.User;
using Movie_Ticket_Booking_Backend.Services.Implementations;

namespace Movie_Ticket_Booking_Backend.Controllers.User
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;
        private readonly JwtService _jwtService;

        public AuthController(AuthService authService, JwtService jwtService)
        {
            _authService = authService;
            _jwtService = jwtService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            var user = await _authService.Login(request.Email, request.Password);

            if (user == null)
                return Unauthorized("Invalid email or password");

            var token = _jwtService.GenerateToken(user);

            var response = new LoginResponse
            {
                Token = token,
                Email = user.Email,
                Role = user.Role.Name
            };

            return Ok(response);
        }
    }
}