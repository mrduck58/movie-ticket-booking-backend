using Movie_Ticket_Booking_Backend.DTOs.Notifications;

namespace Movie_Ticket_Booking_Backend.Services.Interfaces.Notifications
{
    public interface INotificationService
    {
        Task<List<NotificationDto>> GetUserNotifications(string userId);

        Task MarkAsRead(string notificationId);

        Task DeleteNotification(string notificationId);

        Task CreateNotification(CreateNotificationDto dto);
    }
}
