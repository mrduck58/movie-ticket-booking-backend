using Movie_Ticket_Booking_Backend.Domain.Cinemas;
using Movie_Ticket_Booking_Backend.DTOs.Seat;
using Movie_Ticket_Booking_Backend.Repositories.Interfaces;

public class SeatService : ISeatService
{
    private readonly ISeatRepository _seatRepository;

    public SeatService(ISeatRepository seatRepository)
    {
        _seatRepository = seatRepository;
    }

    public async Task<List<SeatDto>> GetSeatsByRoom(string roomId)
    {
        var seats = await _seatRepository.GetSeatsByRoom(roomId);

        return seats.Select(x => new SeatDto
        {
            SeatId = x.SeatId,
            SeatName = x.SeatName,
            SeatType = x.SeatType,
            Status = x.Status,
            RoomId = x.RoomId,
            ShowtimeId = x.ShowtimeId
        }).ToList();
    }

    public async Task<List<SeatDto>> GetSeatMap(string showtimeId)
    {
        var seats = await _seatRepository.GetSeatsByShowtime(showtimeId);

        var result = new List<SeatDto>();

        foreach (var seat in seats)
        {
            string status = "AVAILABLE";

            if (seat.BookingSeats.Any())
                status = "BOOKED";
            else if (seat.SeatLocks.Any(x => x.ExpiredAt > DateTime.UtcNow))
                status = "LOCKED";

            result.Add(new SeatDto
            {
                SeatId = seat.SeatId,
                SeatName = seat.SeatName,
                SeatType = seat.SeatType,
                Status = status,
                RoomId = seat.RoomId,
                ShowtimeId = seat.ShowtimeId
            });
        }

        return result;
    }

    public async Task<SeatDto> CreateSeat(CreateSeatRequest request)
    {
        var seat = new Seat
        {
            SeatId = Guid.NewGuid().ToString(),
            SeatName = request.SeatName,
            SeatType = request.SeatType,
            RoomId = request.RoomId,
            ShowtimeId = request.ShowtimeId,
            Status = "AVAILABLE"
        };

        await _seatRepository.AddSeat(seat);
        await _seatRepository.Save();

        return new SeatDto
        {
            SeatId = seat.SeatId,
            SeatName = seat.SeatName,
            SeatType = seat.SeatType,
            Status = seat.Status
        };
    }

    public async Task<bool> LockSeat(string userId, LockSeatRequest request)
    {
        var seat = await _seatRepository.GetSeat(request.SeatId);

        if (seat == null)
            return false;

        seat.Status = "LOCKED";

        _seatRepository.UpdateSeat(seat);

        await _seatRepository.Save();

        return true;
    }

    public async Task UnlockSeat(string seatId, string showtimeId)
    {
        var seat = await _seatRepository.GetSeat(seatId);

        if (seat != null)
        {
            seat.Status = "AVAILABLE";
            _seatRepository.UpdateSeat(seat);
            await _seatRepository.Save();
        }
    }
}