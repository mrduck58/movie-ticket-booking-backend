namespace Movie_Ticket_Booking_Backend.Models
{
    public class User
    {
        public long Id { get; set; }
        
        public string Phone { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public string FullName { get; set; }

        public string AvatarUrl { get; set; }

        public string Status { get; set; } = "ACTIVE";

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public int RoleId { get; set; }

        public Role Role { get; set; }
    }
}
