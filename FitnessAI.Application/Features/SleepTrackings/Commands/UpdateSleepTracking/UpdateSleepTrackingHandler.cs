using FitnessAI.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Application.Features.SleepTrackings.Commands.UpdateSleepTracking
{
    public class UpdateSleepTrackingHandler
        : IRequestHandler<UpdateSleepTrackingCommand, bool>
    {
        private readonly IUserDbContext _context;

        public UpdateSleepTrackingHandler(IUserDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(
            UpdateSleepTrackingCommand request,
            CancellationToken cancellationToken)
        {
            var sleepTracking = await _context.SleepTrackings
                .FirstOrDefaultAsync(x => x.Id == request.Id);

            if (sleepTracking == null)
            {
                return false;
            }

            sleepTracking.GioBatDauNgu = request.GioBatDauNgu;
            sleepTracking.GioThucDay = request.GioThucDay;

            sleepTracking.TongSoGioNgu =
                (request.GioThucDay - request.GioBatDauNgu).TotalHours;

            sleepTracking.ChatLuongNgu = request.ChatLuongNgu;
            sleepTracking.GhiChu = request.GhiChu;

            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}