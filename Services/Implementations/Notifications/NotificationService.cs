using Movie_Ticket_Booking_Backend.Domain.Notificaions;
using Movie_Ticket_Booking_Backend.DTOs.Notifications;
using Movie_Ticket_Booking_Backend.Repositories.Interfaces.Notifications;
using Movie_Ticket_Booking_Backend.Services.Interfaces.Notifications;

namespace Movie_Ticket_Booking_Backend.Services.Implementations.Notifications
{
    public class NotificationService : INotificationService
    {
        private readonly INotificationRepository _repository;

        public NotificationService(INotificationRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<NotificationDto>> GetUserNotifications(string userId)
        {
            var notifications = await _repository.GetUserNotifications(userId);

            return notifications.Select(n => new NotificationDto
            {
                NotificationId = n.NotificationId,
                Message = n.Message,
                IsRead = n.IsRead,
                CreatedAt = n.CreatedAt
            }).ToList();
        }

        public async Task MarkAsRead(string notificationId)
        {
            var notification = await _repository.GetById(notificationId);

            if (notification == null)
                throw new Exception("Notification not found");

            notification.IsRead = true;

            await _repository.SaveChangesAsync();
        }

        public async Task DeleteNotification(string notificationId)
        {
            var notification = await _repository.GetById(notificationId);

            if (notification == null)
                throw new Exception("Notification not found");

            await _repository.DeleteAsync(notification);

            await _repository.SaveChangesAsync();
        }

        public async Task CreateNotification(CreateNotificationDto dto)
        {
            var notification = new Notification
            {
                NotificationId = Guid.NewGuid().ToString(),
                UserId = dto.UserId,
                WatchListId = dto.WatchListId,
                BlogPostId = dto.BlogPostId,
                CommentId = dto.CommentId,
                BookingSeatId = dto.BookingSeatId,
                Message = dto.Message
            };

            await _repository.AddAsync(notification);

            await _repository.SaveChangesAsync();
        }
    }
}
