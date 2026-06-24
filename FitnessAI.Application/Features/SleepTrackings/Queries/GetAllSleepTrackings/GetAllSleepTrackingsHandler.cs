using FitnessAI.Application.Common.Interfaces;
using FitnessAI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Application.Features.SleepTrackings.Queries.GetAllSleepTrackings
{
    public class GetAllSleepTrackingsHandler
        : IRequestHandler<GetAllSleepTrackingsQuery, List<SleepTracking>>
    {
        private readonly IUserDbContext _context;

        public GetAllSleepTrackingsHandler(IUserDbContext context)
        {
            _context = context;
        }

        public async Task<List<SleepTracking>> Handle(
            GetAllSleepTrackingsQuery request,
            CancellationToken cancellationToken)
        {
            return await _context.SleepTrackings.ToListAsync();
        }
    }
}