using Movie_Ticket_Booking_Backend.Domain.Notificaions;

namespace Movie_Ticket_Booking_Backend.Repositories.Interfaces.Notifications
{
    public interface INotificationRepository
    {
        Task<List<Notification>> GetUserNotifications(string userId);

        Task<Notification?> GetById(string notificationId);

        Task AddAsync(Notification notification);

        Task DeleteAsync(Notification notification);

        Task SaveChangesAsync();
    }
}
