using FitnessAI.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Application.Features.MealPlans.Commands.UpdateMealPlan
{
    public class UpdateMealPlanCommandHandler(
        IUserDbContext context)
        : IRequestHandler<UpdateMealPlanCommand, bool>
    {
        private readonly IUserDbContext _context = context;

        public async Task<bool> Handle(
            UpdateMealPlanCommand request,
            CancellationToken cancellationToken)
        {
            var mealPlan = await _context.MealPlans
                .FirstOrDefaultAsync(
                    x => x.Id == request.Id,
                    cancellationToken);

            if (mealPlan == null)
                return false;

            mealPlan.TenThucDon = request.TenThucDon;
            mealPlan.MoTa = request.MoTa;
            mealPlan.Calories = request.Calories;
            mealPlan.ThoiGian = request.ThoiGian;
            mealPlan.UserId = request.UserId;

            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}