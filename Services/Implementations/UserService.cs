using Movie_Ticket_Booking_Backend.Data;
using Movie_Ticket_Booking_Backend.Domain.Users;
using Movie_Ticket_Booking_Backend.Domain.Movies;
using Movie_Ticket_Booking_Backend.DTOs.User;
using System.Security.Cryptography;
using System.Text;

namespace Movie_Ticket_Booking_Backend.Services
{
    public class UserService
    {
        private readonly AppDbContext _context;

        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<User> RegisterUser(RegisterUserRequest dto)
        {
            var userId = Guid.NewGuid().ToString();

            var user = new User
            {
                UserId = userId,
                Email = dto.Email,
                Phone = dto.Phone,
                FullName = dto.FullName,
                DateOfBirth = dto.DateOfBirth,
                PasswordHash = HashPassword(dto.Password),
                AvatarUrl = "https://default-avatar.png",
                Status = "ACTIVE",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                RoleId = "ROLE002"
            };

            _context.Users.Add(user);

            if (dto.FavoriteGenres != null && dto.FavoriteGenres.Any())
            {
                var userGenres = dto.FavoriteGenres.Select(g => new UserGenre
                {
                    UserId = userId,
                    GenreId = g
                }).ToList();

                _context.UserGenres.AddRange(userGenres);
            }

            await _context.SaveChangesAsync();

            return user;
        }

        private string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(password);
            var hash = sha256.ComputeHash(bytes);

            return Convert.ToBase64String(hash);
        }
    }
}