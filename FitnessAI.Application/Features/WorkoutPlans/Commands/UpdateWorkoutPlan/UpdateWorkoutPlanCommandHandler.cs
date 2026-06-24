using FitnessAI.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Application.Features.WorkoutPlans.Commands.UpdateWorkoutPlan
{
    public class UpdateWorkoutPlanCommandHandler(
        IUserDbContext context)
        : IRequestHandler<UpdateWorkoutPlanCommand, bool>
    {
        private readonly IUserDbContext _context = context;

        public async Task<bool> Handle(
            UpdateWorkoutPlanCommand request,
            CancellationToken cancellationToken)
        {
            var workoutPlan = await _context.WorkoutPlans
                .FirstOrDefaultAsync(
                    x => x.Id == request.Id,
                    cancellationToken);

            if (workoutPlan == null)
                return false;

            workoutPlan.TenBaiTap = request.TenBaiTap;
            workoutPlan.MoTa = request.MoTa;
            workoutPlan.SoNgay = request.SoNgay;
            workoutPlan.MucTieu = request.MucTieu;
            workoutPlan.UserId = request.UserId;

            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}