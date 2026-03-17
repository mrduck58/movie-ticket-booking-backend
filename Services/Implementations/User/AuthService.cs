using Microsoft.EntityFrameworkCore;
using Movie_Ticket_Booking_Backend.Data;
using Movie_Ticket_Booking_Backend.Domain.Users;

namespace Movie_Ticket_Booking_Backend.Services.Implementations.User
{
    public class AuthService
    {
        private readonly AppDbContext _context;

        public AuthService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Domain.Users.User?> Login(string email, string password)
        {
            var user = await _context.Users
                .Include(x => x.Role)
                .FirstOrDefaultAsync(x => x.Email == email);

            if (user == null)
                return null;

            if (user.PasswordHash != password)
                return null;

            return user;
        }
    }
}