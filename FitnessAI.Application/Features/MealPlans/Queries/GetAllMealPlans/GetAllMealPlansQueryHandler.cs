using FitnessAI.Application.Common.Interfaces;
using FitnessAI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Application.Features.MealPlans.Queries.GetAllMealPlans
{
    public class GetAllMealPlansQueryHandler(
        IUserDbContext context)
        : IRequestHandler<
            GetAllMealPlansQuery,
            List<MealPlan>>
    {
        private readonly IUserDbContext _context = context;

        public async Task<List<MealPlan>> Handle(
            GetAllMealPlansQuery request,
            CancellationToken cancellationToken)
        {
            var mealPlans = await _context.MealPlans
        .Include(x => x.User)
        .ToListAsync(cancellationToken);

            return mealPlans;
        }
    }
}