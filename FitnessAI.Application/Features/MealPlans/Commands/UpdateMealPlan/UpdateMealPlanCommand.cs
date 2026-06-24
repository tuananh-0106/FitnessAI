using MediatR;

namespace FitnessAI.Application.Features.MealPlans.Commands.UpdateMealPlan
{
    public class UpdateMealPlanCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public string TenThucDon { get; set; } = string.Empty;

        public string MoTa { get; set; } = string.Empty;

        public int Calories { get; set; }

        public string ThoiGian { get; set; } = string.Empty;

        public int UserId { get; set; }
    }
}