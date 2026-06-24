using FitnessAI.Domain.Entities;
using FitnessAI.Application.Common.Interfaces;
using MediatR;

namespace FitnessAI.Application.Features.MealPlans.Commands.CreateMealPlan
{
    public class CreateMealPlanCommandHandler
        : IRequestHandler<CreateMealPlanCommand, int>
    {
        private readonly IUserDbContext _context;

        public CreateMealPlanCommandHandler(
            IUserDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(
            CreateMealPlanCommand request,
            CancellationToken cancellationToken)
        {
            var mealPlan = new MealPlan
            {
                TenThucDon = request.TenThucDon,
                MucTieu = request.MucTieu,
                Calories = request.Calories,
                Protein = request.Protein,
                Carbs = request.Carbs,
                Fat = request.Fat,
                DanhSachMonAn = request.DanhSachMonAn,
                MoTa = request.MoTa,
                ThoiGian = request.ThoiGian,
                UserId = request.UserId,
                NgayTao = DateTime.Now
            };

            _context.MealPlans.Add(mealPlan);

            await _context.SaveChangesAsync(cancellationToken);

            return mealPlan.Id;
        }
    }
}