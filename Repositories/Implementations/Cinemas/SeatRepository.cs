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

    public async Task<List<Seat>> GetSeatsByRoomAsync(string roomId)
    {
        return await _context.Seats
            .Where(x => x.RoomId == roomId)
            .ToListAsync();
    }

    public async Task<List<string>> GetBookedSeatIdsAsync(string showtimeId)
    {
        return await _context.BookingSeats
            .Where(x => x.ShowtimeTicketType.ShowtimeId == showtimeId)
            .Select(x => x.SeatId)
            .ToListAsync();
    }

    public async Task<List<string>> GetLockedSeatIdsAsync(string showtimeId)
    {
        return await _context.SeatLocks
            .Where(x => x.ShowtimeId == showtimeId)
            .Select(x => x.SeatId)
            .ToListAsync();
    }

    public async Task<List<Seat>> GetSeatsByRoom(string roomId)
    {
        return await _context.Seats
            .Where(x => x.RoomId == roomId)
            .ToListAsync();
    }

    //public async Task<List<Seat>> GetSeatsByShowtimeAsync(string showtimeId)
    //{
    //    return await _context.Seats
    //        .Where(s => s. == showtimeId)
    //        .Include(s => s.BookingSeats)
    //        .ToListAsync();
    //}

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