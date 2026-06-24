using FitnessAI.Application.Common.Interfaces;
using FitnessAI.Domain.Entities;
using MediatR;

namespace FitnessAI.Application.Features.SleepTrackings.Commands.CreateSleepTracking
{
    public class CreateSleepTrackingHandler
        : IRequestHandler<CreateSleepTrackingCommand, int>
    {
        private readonly IUserDbContext _context;

        public CreateSleepTrackingHandler(IUserDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(
            CreateSleepTrackingCommand request,
            CancellationToken cancellationToken)
        {
            var tongSoGioNgu =
                (request.GioThucDay - request.GioBatDauNgu).TotalHours;

            var sleepTracking = new SleepTracking
            {
                UserId = request.UserId,
                GioBatDauNgu = request.GioBatDauNgu,
                GioThucDay = request.GioThucDay,
                TongSoGioNgu = tongSoGioNgu,
                ChatLuongNgu = request.ChatLuongNgu,
                GhiChu = request.GhiChu
            };

            _context.SleepTrackings.Add(sleepTracking);

            await _context.SaveChangesAsync(cancellationToken);

            return sleepTracking.Id;
        }
    }
}