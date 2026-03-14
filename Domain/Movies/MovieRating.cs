using Movie_Ticket_Booking_Backend.Domain.Users;

namespace Movie_Ticket_Booking_Backend.Domain.Movies
{
    public class MovieRating
    {
        public string MovieRatingId { get; set; }
        public string MovieId { get; set; }
        public Movie Movie { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public double Value { get; set; }
    }
}
