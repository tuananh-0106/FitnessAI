using FitnessAI.Application.Common.Interfaces;
using FitnessAI.Domain.Entities;
using MediatR;

using ProgressEntity = FitnessAI.Domain.Entities.Progress;
namespace FitnessAI.Application.Features.Progress.Commands.CreateProgress
{
    public class CreateProgressCommandHandler
        : IRequestHandler<CreateProgressCommand, int>
    {
        private readonly IUserDbContext _context;

        public CreateProgressCommandHandler(
            IUserDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(
            CreateProgressCommand request,
            CancellationToken cancellationToken)
        {
            double bmi = request.CanNang /
                Math.Pow(request.ChieuCao / 100, 2);

            var progress = new ProgressEntity
            {
                CanNang = request.CanNang,
                ChieuCao = request.ChieuCao,
                BMI = Math.Round(bmi, 2),
                MoCoThe = request.MoCoThe,
                KhoiLuongCo = request.KhoiLuongCo,
                CaloriesDotChay = request.CaloriesDotChay,
                GhiChu = request.GhiChu,
                UserId = request.UserId,
                NgayCapNhat = DateTime.Now
            };

            _context.Progresses.Add(progress);

            await _context.SaveChangesAsync(cancellationToken);

            return progress.Id;
        }
    }
}