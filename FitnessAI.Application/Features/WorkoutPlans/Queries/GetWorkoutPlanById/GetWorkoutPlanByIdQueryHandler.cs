using FitnessAI.Application.Common.Interfaces;
using FitnessAI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Application.Features.WorkoutPlans.Queries.GetWorkoutPlanById
{
    public class GetWorkoutPlanByIdQueryHandler(
        IUserDbContext context)
        : IRequestHandler<
            GetWorkoutPlanByIdQuery,
            WorkoutPlan?>
    {
        private readonly IUserDbContext _context = context;

        public async Task<WorkoutPlan?> Handle(
            GetWorkoutPlanByIdQuery request,
            CancellationToken cancellationToken)
        {
            return await _context.WorkoutPlans
                .FirstOrDefaultAsync(
                    x => x.Id == request.Id,
                    cancellationToken);
        }
    }
}