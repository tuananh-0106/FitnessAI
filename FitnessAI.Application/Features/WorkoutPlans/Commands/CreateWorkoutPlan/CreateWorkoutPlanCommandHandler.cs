using FitnessAI.Application.Common.Interfaces;
using FitnessAI.Domain.Entities;
using MediatR;

namespace FitnessAI.Application.Features.WorkoutPlans.Commands.CreateWorkoutPlan
{
    public class CreateWorkoutPlanCommandHandler
        : IRequestHandler<CreateWorkoutPlanCommand, int>
    {
        private readonly IUserDbContext _context;

        public CreateWorkoutPlanCommandHandler(
            IUserDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(
            CreateWorkoutPlanCommand request,
            CancellationToken cancellationToken)
        {
            var workout = new WorkoutPlan
            {
                TenBaiTap = request.TenBaiTap,
                MucTieu = request.MucTieu,
                CapDo = request.CapDo,
                DanhSachBaiTap = request.DanhSachBaiTap,
                SoNgayTap = request.SoNgayTap,
                CaloriesDotChay = request.CaloriesDotChay,
                MoTa = request.MoTa,
                UserId = request.UserId,
                NgayTao = DateTime.Now
            };

            _context.WorkoutPlans.Add(workout);

            await _context.SaveChangesAsync(cancellationToken);

            return workout.Id;
        }
    }
}   