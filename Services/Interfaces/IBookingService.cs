using Movie_Ticket_Booking_Backend.DTOs.Booking;

public interface IBookingService
{
    Task<BookingDto> CreateBooking(string userId, CreateBookingRequest request);

    Task<BookingDto?> GetBooking(string bookingId);
    Task<List<BookingDto>> GetUserBookings(string userId);
}