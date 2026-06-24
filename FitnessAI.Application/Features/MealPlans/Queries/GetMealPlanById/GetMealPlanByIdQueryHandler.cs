using FitnessAI.Application.Common.Interfaces;
using FitnessAI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Application.Features.MealPlans.Queries.GetMealPlanById
{
    public class GetMealPlanByIdQueryHandler(
        IUserDbContext context)
        : IRequestHandler<
            GetMealPlanByIdQuery,
            MealPlan?>
    {
        private readonly IUserDbContext _context = context;

        public async Task<MealPlan?> Handle(
            GetMealPlanByIdQuery request,
            CancellationToken cancellationToken)
        {
            return await _context.MealPlans
                .FirstOrDefaultAsync(
                    x => x.Id == request.Id,
                    cancellationToken);
        }
    }
}