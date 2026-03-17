using Microsoft.EntityFrameworkCore;
using Movie_Ticket_Booking_Backend.Data;
using Movie_Ticket_Booking_Backend.Domain.Bookings;
using Movie_Ticket_Booking_Backend.DTOs.Booking;
using Movie_Ticket_Booking_Backend.Repositories.Interfaces;

public class BookingService : IBookingService
{
    private readonly IBookingRepository _bookingRepository;
    private readonly ISeatRepository _seatRepository;
    private readonly AppDbContext _context;
    public BookingService(
        AppDbContext context,
        IBookingRepository bookingRepository,
        ISeatRepository seatRepository)
    {
        _context = context;
        _bookingRepository = bookingRepository;
        _seatRepository = seatRepository;
    }

    public async Task<BookingDto> CreateBooking(string userId, CreateBookingRequest request)
    {
        var booking = new Booking
        {
            BookingId = Guid.NewGuid().ToString(),
            UserId = userId,
            ShowtimeId = request.ShowtimeId,
            CreatedAt = DateTime.UtcNow,
            Status = "PENDING",
            BookingSeats = new List<BookingSeat>(),
            BookingFoodCombos = new List<BookingFoodCombo>(),
            BookingVouchers = new List<BookingVoucher>()
        };

        double total = 0;

        // 1️ Seats
        foreach (var seatId in request.SeatIds)
        {
            var seat = await _seatRepository.GetSeat(seatId);

            if (seat == null)
                throw new Exception("Seat not found");

            var bookingSeat = new BookingSeat
            {
                BookingSeatId = Guid.NewGuid().ToString(),
                BookingId = booking.BookingId,
                SeatId = seatId,
                Price = 100000,
                QrCode = Guid.NewGuid().ToString(),
                Status = "BOOKED"
            };

            booking.BookingSeats.Add(bookingSeat);

            total += bookingSeat.Price;
        }

        // 2️ Food Combo
        if (request.Combos != null)
        {
            foreach (var combo in request.Combos)
            {
                var bookingCombo = new BookingFoodCombo
                {
                    BookingFoodComboId = Guid.NewGuid().ToString(),
                    BookingId = booking.BookingId,
                    FoodComboId = combo.FoodComboId,
                    Quantity = combo.Quantity
                };

                booking.BookingFoodCombos.Add(bookingCombo);

                total += 50000 * combo.Quantity;
            }
        }

        // 3️ Voucher
        if (!string.IsNullOrEmpty(request.VoucherCode))
        {
            var bookingVoucher = new BookingVoucher
            {
                BookingId = booking.BookingId,
                VoucherId = request.VoucherCode
            };

            booking.BookingVouchers.Add(bookingVoucher);

            total -= 20000;
        }

        booking.TotalAmount = total;

        await _bookingRepository.AddBooking(booking);

        await _bookingRepository.Save();

        return new BookingDto
        {
            BookingId = booking.BookingId,
            ShowtimeId = booking.ShowtimeId,
            TotalAmount = booking.TotalAmount,
            Status = booking.Status,
            CreatedAt = booking.CreatedAt
        };
    }

    public async Task<BookingDto?> GetBooking(string bookingId)
    {
        var booking = await _bookingRepository.GetBooking(bookingId);

        if (booking == null)
            return null;

        return new BookingDto
        {
            BookingId = booking.BookingId,
            ShowtimeId = booking.ShowtimeId,
            TotalAmount = booking.TotalAmount,
            Status = booking.Status,
            CreatedAt = booking.CreatedAt
        };
    }

    public async Task<List<BookingDto>> GetUserBookings(string userId)
    {
        var bookings = await _context.Bookings
            .Include(x => x.Showtime)
            .Where(x => x.UserId == userId)
            .OrderByDescending(x => x.CreatedAt)
            .ToListAsync();

        return bookings.Select(x => new BookingDto
        {
            BookingId = x.BookingId,
            ShowtimeId = x.ShowtimeId,
            TotalAmount = x.TotalAmount,
            Status = x.Status,
            CreatedAt = x.CreatedAt
        }).ToList();
    }
}