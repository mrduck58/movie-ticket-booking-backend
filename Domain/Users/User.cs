using Movie_Ticket_Booking_Backend.Domain.Blogs;
using Movie_Ticket_Booking_Backend.Domain.Cinemas;
using Movie_Ticket_Booking_Backend.Domain.Movies;
using Movie_Ticket_Booking_Backend.Domain.Bookings;

namespace Movie_Ticket_Booking_Backend.Domain.Users
{
    public class User
    {
        public string UserId { get; set; }
        
        public string Phone { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public string FullName { get; set; }

        public string AvatarUrl { get; set; }

        public string Status { get; set; } = "ACTIVE";

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public string RoleId { get; set; }

        public Role Role { get; set; }

        public ICollection<MovieRating> MovieRatings { get; set; }
        public ICollection<Booking> Bookings { get; set; }
        public ICollection<SeatLock> SeatLocks { get; set; }
        public ICollection<BlogPost> BlogPosts { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
