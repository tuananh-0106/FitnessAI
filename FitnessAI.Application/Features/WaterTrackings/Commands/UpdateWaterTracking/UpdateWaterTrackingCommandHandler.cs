using FitnessAI.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Application.Features.WaterTrackings.Commands.UpdateWaterTracking
{
    public class UpdateWaterTrackingHandler
        : IRequestHandler<UpdateWaterTrackingCommand, bool>
    {
        private readonly IUserDbContext _context;

        public UpdateWaterTrackingHandler(IUserDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(
            UpdateWaterTrackingCommand request,
            CancellationToken cancellationToken)
        {
            var waterTracking = await _context.WaterTrackings
                .FirstOrDefaultAsync(x => x.Id == request.Id);

            if (waterTracking == null)
            {
                return false;
            }

            waterTracking.LuongNuocML = request.LuongNuocML;

            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}