using Movie_Ticket_Booking_Backend.Domain.Movies;
using Movie_Ticket_Booking_Backend.DTOs.Movie;
using Movie_Ticket_Booking_Backend.Repositories.Interfaces.Movies;
using Movie_Ticket_Booking_Backend.Services.Interfaces.Movies;

namespace Movie_Ticket_Booking_Backend.Services.Implementations.Movie
{
    public class WatchListService : IWatchListService
    {
        private readonly IWatchListRepository _repository;

        public WatchListService(IWatchListRepository repository)
        {
            _repository = repository;
        }

        public async Task AddAsync(AddWatchListDto dto)
        {
            var existing = await _repository.GetAsync(dto.UserId, dto.MovieId);

            if (existing != null)
                throw new Exception("Movie already in watchlist");

            var watchList = new WatchList
            {
                WatchListId = Guid.NewGuid().ToString(),
                UserId = dto.UserId,
                MovieId = dto.MovieId,
                type = dto.type
            };

            await _repository.AddAsync(watchList);
        }

        public async Task<List<WatchListDto>> GetUserWatchList(string userId)
        {
            var data = await _repository.GetByUserIdAsync(userId);

            return data.Select(w => new WatchListDto
            {
                WatchListId = w.WatchListId,
                MovieId = w.MovieId,
                Title = w.Movie!.Title,
                PosterUrl = w.Movie.Posters.FirstOrDefault()?.ImageUrl ?? "",
                type = w.type,
                CreatedAt = w.CreatedAt
            }).ToList();
        }

        public async Task RemoveAsync(string userId, string movieId)
        {
            var item = await _repository.GetAsync(userId, movieId);

            if (item == null)
                throw new Exception("Watchlist item not found");

            await _repository.DeleteAsync(item);
        }
    }
}
