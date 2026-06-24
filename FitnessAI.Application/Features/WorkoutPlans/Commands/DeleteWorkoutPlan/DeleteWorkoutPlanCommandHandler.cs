using FitnessAI.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Application.Features.WorkoutPlans.Commands.DeleteWorkoutPlan
{
    public class DeleteWorkoutPlanCommandHandler(
        IUserDbContext context)
        : IRequestHandler<DeleteWorkoutPlanCommand, bool>
    {
        private readonly IUserDbContext _context = context;

        public async Task<bool> Handle(
            DeleteWorkoutPlanCommand request,
            CancellationToken cancellationToken)
        {
            var workoutPlan = await _context.WorkoutPlans
                .FirstOrDefaultAsync(
                    x => x.Id == request.Id,
                    cancellationToken);

            if (workoutPlan == null)
                return false;

            _context.WorkoutPlans.Remove(workoutPlan);

            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}