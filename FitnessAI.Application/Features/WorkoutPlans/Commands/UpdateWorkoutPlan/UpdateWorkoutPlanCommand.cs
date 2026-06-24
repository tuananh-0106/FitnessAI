using MediatR;

namespace FitnessAI.Application.Features.WorkoutPlans.Commands.UpdateWorkoutPlan
{
    public class UpdateWorkoutPlanCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public string TenBaiTap { get; set; } = string.Empty;

        public string MoTa { get; set; } = string.Empty;

        public int SoNgay { get; set; }

        public string MucTieu { get; set; } = string.Empty;

        public int UserId { get; set; }
    }
}