using MediatR;

namespace FitnessAI.Application.Notifications.Events
{
    public class HealthAnalysisCreatedEvent : INotification
    {
        public int UserId { get; set; }
        public double BMI { get; set; }
        public DateTime CreatedAt { get; set; }

        public HealthAnalysisCreatedEvent(int userId, double bmi)
        {
            UserId = userId;
            BMI = bmi;
            CreatedAt = DateTime.UtcNow;
        }
    }
}