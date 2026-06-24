using FitnessAI.Application.Common.Interfaces;
using FitnessAI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Application.Features.WaterTrackings.Queries.GetWaterTrackingById
{
    public class GetWaterTrackingByIdHandler
        : IRequestHandler<GetWaterTrackingByIdQuery, WaterTracking?>
    {
        private readonly IUserDbContext _context;

        public GetWaterTrackingByIdHandler(IUserDbContext context)
        {
            _context = context;
        }

        public async Task<WaterTracking?> Handle(
            GetWaterTrackingByIdQuery request,
            CancellationToken cancellationToken)
        {
            return await _context.WaterTrackings
                .FirstOrDefaultAsync(x => x.Id == request.Id);
        }
    }
}