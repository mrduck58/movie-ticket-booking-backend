using Movie_Ticket_Booking_Backend.Domain.Movies;
using Movie_Ticket_Booking_Backend.DTOs.Movie;
using Movie_Ticket_Booking_Backend.Repositories.Interfaces;
using Movie_Ticket_Booking_Backend.Services.Interfaces;

public class MovieService : IMovieService
{
    private readonly IMovieRepository _movieRepository;

    public MovieService(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    public async Task<List<MovieDto>> GetMovies()
    {
        var movies = await _movieRepository.GetAllMovies();

        return movies.Select(x => new MovieDto
        {
            MovieId = x.MovieId,
            Title = x.Title,
            TitleVn = x.TitleVn,
            Duration = x.Duration,
            Rating = x.Rating
        }).ToList();
    }

    public async Task<MovieDto?> GetMovie(string id)
    {
        var movie = await _movieRepository.GetMovieById(id);

        if (movie == null) return null;

        return new MovieDto
        {
            MovieId = movie.MovieId,
            Title = movie.Title,
            TitleVn = movie.TitleVn,
            Duration = movie.Duration,
            Rating = movie.Rating
        };
    }

    public async Task<MovieDto> CreateMovie(CreateMovieRequest request)
    {
        var movie = new Movie
        {
            MovieId = Guid.NewGuid().ToString(),
            Title = request.Title,
            TitleVn = request.TitleVn,
            Description = request.Description,
            TrailerUrl = request.TrailerUrl,
            Director = request.Director,
            Duration = request.Duration,
            Rating = request.Rating,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow,
            Status = "ACTIVE"
        };

        await _movieRepository.AddMovie(movie);

        await _movieRepository.Save();

        return new MovieDto
        {
            MovieId = movie.MovieId,
            Title = movie.Title,
            TitleVn = movie.TitleVn,
            Duration = movie.Duration,
            Rating = movie.Rating
        };
    }

    public async Task<bool> DeleteMovie(string id)
    {
        var movie = await _movieRepository.GetMovieById(id);

        if (movie == null) return false;

        _movieRepository.DeleteMovie(movie);

        await _movieRepository.Save();

        return true;
    }
}