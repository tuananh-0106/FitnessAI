using FitnessAI.Application.Common.Interfaces;
using FitnessAI.Domain.Entities;

using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Application.Features.WaterTrackings.Queries.GetAllWaterTrackings
{
    public class GetAllWaterTrackingsHandler
        : IRequestHandler<GetAllWaterTrackingsQuery, List<WaterTracking>>
    {
        private readonly IUserDbContext _context;

        public GetAllWaterTrackingsHandler(IUserDbContext context)
        {
            _context = context;
        }

        public async Task<List<WaterTracking>> Handle(
            GetAllWaterTrackingsQuery request,
            CancellationToken cancellationToken)
        {
            return await _context.WaterTrackings.ToListAsync();
        }
    }
}