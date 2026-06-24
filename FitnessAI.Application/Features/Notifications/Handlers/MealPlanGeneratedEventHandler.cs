using MediatR;
using FitnessAI.Application.Notifications.Events;

namespace FitnessAI.Application.Notifications.Handlers
{
    public class MealPlanGeneratedEventHandler
        : INotificationHandler<MealPlanGeneratedEvent>
    {
        public async Task Handle(MealPlanGeneratedEvent notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"🍽 Meal Plan created for User: {notification.UserId}");
            Console.WriteLine($"📌 Plan: {notification.PlanName}");

            // TODO:
            // - gửi email
            // - push notification mobile
            // - lưu log AI recommendation

            await Task.CompletedTask;
        }
    }
}