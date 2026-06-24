using FitnessAI.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Application.Features.WaterTrackings.Commands.DeleteWaterTracking
{
    public class DeleteWaterTrackingHandler
        : IRequestHandler<DeleteWaterTrackingCommand, bool>
    {
        private readonly IUserDbContext _context;

        public DeleteWaterTrackingHandler(IUserDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(
            DeleteWaterTrackingCommand request,
            CancellationToken cancellationToken)
        {
            var waterTracking = await _context.WaterTrackings
                .FirstOrDefaultAsync(x => x.Id == request.Id);

            if (waterTracking == null)
            {
                return false;
            }

            _context.WaterTrackings.Remove(waterTracking);

            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}