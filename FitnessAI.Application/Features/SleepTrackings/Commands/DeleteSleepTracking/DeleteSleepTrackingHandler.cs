using FitnessAI.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Application.Features.SleepTrackings.Commands.DeleteSleepTracking
{
    public class DeleteSleepTrackingHandler
        : IRequestHandler<DeleteSleepTrackingCommand, bool>
    {
        private readonly IUserDbContext _context;

        public DeleteSleepTrackingHandler(IUserDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(
            DeleteSleepTrackingCommand request,
            CancellationToken cancellationToken)
        {
            var sleepTracking = await _context.SleepTrackings
                .FirstOrDefaultAsync(x => x.Id == request.Id);

            if (sleepTracking == null)
            {
                return false;
            }

            _context.SleepTrackings.Remove(sleepTracking);

            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}