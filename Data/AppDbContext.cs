using Microsoft.EntityFrameworkCore;
using Movie_Ticket_Booking_Backend.Models;

namespace Movie_Ticket_Booking_Backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }
    }
}
