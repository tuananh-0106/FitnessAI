using FitnessAI.Domain.Entities;
using MediatR;

namespace FitnessAI.Application.Features.MealPlans.Commands.CreateMealPlan
{
    public class CreateMealPlanCommand : IRequest<int>
    {
        public string TenThucDon { get; set; } = string.Empty;

        public string MucTieu { get; set; } = string.Empty;

        public int Calories { get; set; }

        public int Protein { get; set; }

        public int Carbs { get; set; }

        public int Fat { get; set; }

        public string DanhSachMonAn { get; set; } = string.Empty;

        public string MoTa { get; set; } = string.Empty;

        public int UserId { get; set; }

        public string ThoiGian { get; set; } = string.Empty;
    }
}