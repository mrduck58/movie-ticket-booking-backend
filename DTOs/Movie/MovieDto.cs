namespace Movie_Ticket_Booking_Backend.DTOs.Movie
{
    public class MovieDto
    {
        public string MovieId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string TitleVn { get; set; } = string.Empty;
        public double Duration { get; set; }
        public double Rating { get; set; }
        public string Director { get; set; }
        public string PosterUrl { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
