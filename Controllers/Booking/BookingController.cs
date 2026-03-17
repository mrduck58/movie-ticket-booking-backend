using Microsoft.AspNetCore.Mvc;
using Movie_Ticket_Booking_Backend.DTOs.Booking;

[ApiController]
[Route("api/bookings")]
public class BookingController : ControllerBase
{
    private readonly IBookingService _bookingService;

    public BookingController(IBookingService bookingService)
    {
        _bookingService = bookingService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateBooking(CreateBookingRequest request)
    {
        var userId = "mock-user";

        var booking = await _bookingService.CreateBooking(userId, request);

        return Ok(booking);
    }

    [HttpGet("{bookingId}")]
    public async Task<IActionResult> GetBooking(string bookingId)
    {
        var booking = await _bookingService.GetBooking(bookingId);

        if (booking == null)
            return NotFound();

        return Ok(booking);
    }

    [HttpGet("my-bookings")]
    public async Task<IActionResult> GetMyBookings()
    {
        var userId = User.FindFirst("id")?.Value;

        var bookings = await _bookingService.GetUserBookings(userId);

        return Ok(bookings);
    }
}