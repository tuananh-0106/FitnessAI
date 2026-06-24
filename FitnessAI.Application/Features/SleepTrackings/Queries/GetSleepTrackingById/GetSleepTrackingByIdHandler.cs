using FitnessAI.Application.Common.Interfaces;
using FitnessAI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Application.Features.SleepTrackings.Queries.GetSleepTrackingById
{
    public class GetSleepTrackingByIdHandler
        : IRequestHandler<GetSleepTrackingByIdQuery, SleepTracking?>
    {
        private readonly IUserDbContext _context;

        public GetSleepTrackingByIdHandler(IUserDbContext context)
        {
            _context = context;
        }

        public async Task<SleepTracking?> Handle(
            GetSleepTrackingByIdQuery request,
            CancellationToken cancellationToken)
        {
            return await _context.SleepTrackings
                .FirstOrDefaultAsync(x => x.Id == request.Id);
        }
    }
}