using MediatR;
using FitnessAI.Application.Notifications.Events;

namespace FitnessAI.Application.Notifications.Handlers
{
    public class HealthAnalysisCreatedEventHandler
        : INotificationHandler<HealthAnalysisCreatedEvent>
    {
        public async Task Handle(HealthAnalysisCreatedEvent notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"[HEALTH] User: {notification.UserId}");

            if (notification.BMI >= 25)
            {
                Console.WriteLine("⚠️ Cảnh báo: BMI cao - đề xuất giảm cân");
            }
            else if (notification.BMI < 18.5)
            {
                Console.WriteLine("⚠️ Cảnh báo: Thiếu cân - cần tăng dinh dưỡng");
            }
            else
            {
                Console.WriteLine("✅ BMI bình thường - duy trì chế độ");
            }

            await Task.CompletedTask;
        }
    }
}