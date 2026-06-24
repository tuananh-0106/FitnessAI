using FitnessAI.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Application.Features.MealPlans.Commands.DeleteMealPlan
{
    public class DeleteMealPlanCommandHandler(
        IUserDbContext context)
        : IRequestHandler<DeleteMealPlanCommand, bool>
    {
        private readonly IUserDbContext _context = context;

        public async Task<bool> Handle(
            DeleteMealPlanCommand request,
            CancellationToken cancellationToken)
        {
            var mealPlan = await _context.MealPlans
                .FirstOrDefaultAsync(
                    x => x.Id == request.Id,
                    cancellationToken);

            if (mealPlan == null)
                return false;

            _context.MealPlans.Remove(mealPlan);

            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}