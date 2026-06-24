using MediatR;

namespace FitnessAI.Application.Features.WorkoutPlans.Commands.CreateWorkoutPlan
{
    public class CreateWorkoutPlanCommand : IRequest<int>
    {
        public string TenBaiTap { get; set; } = string.Empty;

        public string MucTieu { get; set; } = string.Empty;

        public string CapDo { get; set; } = string.Empty;

        public string DanhSachBaiTap { get; set; } = string.Empty;

        public int SoNgayTap { get; set; }

        public int CaloriesDotChay { get; set; }

        public string MoTa { get; set; } = string.Empty;

        public int UserId { get; set; }
    }
}