using Microsoft.AspNetCore.Mvc;
using Movie_Ticket_Booking_Backend.DTOs.Notifications;
using Movie_Ticket_Booking_Backend.Services.Interfaces.Notifications;

namespace Movie_Ticket_Booking_Backend.Controllers.Notifications
{
    [ApiController]
    [Route("api/notifications")]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _service;

        public NotificationController(INotificationService service)
        {
            _service = service;
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetUserNotifications(string userId)
        {
            var result = await _service.GetUserNotifications(userId);

            if (!result.Any())
                return NotFound(new { message = "No notifications found" });

            return Ok(result);
        }

        [HttpPut("{notificationId}/read")]
        public async Task<IActionResult> MarkAsRead(string notificationId)
        {
            try
            {
                await _service.MarkAsRead(notificationId);
                return Ok(new { message = "Notification marked as read" });
            }
            catch (Exception ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }

        [HttpDelete("{notificationId}")]
        public async Task<IActionResult> Delete(string notificationId)
        {
            try
            {
                await _service.DeleteNotification(notificationId);
                return Ok(new { message = "Notification deleted" });
            }
            catch (Exception ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateNotificationDto dto)
        {
            if (dto == null)
            {
                return BadRequest(new { message = "Invalid request body" });
            }

            if (string.IsNullOrEmpty(dto.UserId))
            {
                return BadRequest(new { message = "UserId is required" });
            }

            if (string.IsNullOrEmpty(dto.Message))
            {
                return BadRequest(new { message = "Message is required" });
            }

            try
            {
                await _service.CreateNotification(dto);
                return Ok(new { message = "Notification created" });
            }
            catch (Exception ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }
    }
}
