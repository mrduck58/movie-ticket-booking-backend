using Microsoft.EntityFrameworkCore;
using Movie_Ticket_Booking_Backend.Data;
using Movie_Ticket_Booking_Backend.Domain.Cinemas;
using Movie_Ticket_Booking_Backend.Repositories.Interfaces.Cinemas;

public class SeatRepository : ISeatRepository
{
    private readonly AppDbContext _context;

    public SeatRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Seat>> GetSeatsByRoom(string roomId)
    {
        return await _context.Seats
            .Where(x => x.RoomId == roomId)
            .ToListAsync();
    }

    public async Task<List<Seat>> GetSeatsByShowtime(string showtimeId)
    {
        return await _context.Seats
            .Include(x => x.BookingSeats)
            .Include(x => x.SeatLocks)
            .Where(x => x.ShowtimeId == showtimeId)
            .ToListAsync();
    }

    public async Task<Seat?> GetSeat(string seatId)
    {
        return await _context.Seats
            .FirstOrDefaultAsync(x => x.SeatId == seatId);
    }

    public async Task AddSeat(Seat seat)
    {
        await _context.Seats.AddAsync(seat);
    }

    public void UpdateSeat(Seat seat)
    {
        _context.Seats.Update(seat);
    }

    public async Task Save()
    {
        await _context.SaveChangesAsync();
    }
}