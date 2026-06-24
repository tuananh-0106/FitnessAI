namespace FitnessAI.Application.Notifications.Models
{
    public class NotificationMessage
    {
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}