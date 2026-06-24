using FitnessAI.Application.Common.Interfaces;
using FitnessAI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Application.Features.WorkoutPlans.Queries.GetAllWorkoutPlans
{
    public class GetAllWorkoutPlansQueryHandler
        : IRequestHandler<GetAllWorkoutPlansQuery, List<WorkoutPlan>>
    {
        private readonly IUserDbContext _context;

        public GetAllWorkoutPlansQueryHandler(
            IUserDbContext context)
        {
            _context = context;
        }

        public async Task<List<WorkoutPlan>> Handle(
            GetAllWorkoutPlansQuery request,
            CancellationToken cancellationToken)
        {
            return await _context.WorkoutPlans
                .Include(x => x.User)
                .ToListAsync(cancellationToken);
        }
    }
}