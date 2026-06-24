using MediatR;

namespace FitnessAI.Application.Notifications.Events
{
    public class MealPlanGeneratedEvent : INotification
    {
        public int UserId { get; set; }
        public string PlanName { get; set; }

        public MealPlanGeneratedEvent(int userId, string planName)
        {
            UserId = userId;
            PlanName = planName;
        }
    }
}