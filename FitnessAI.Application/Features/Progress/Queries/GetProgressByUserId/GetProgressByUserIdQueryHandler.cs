using FitnessAI.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Application.Features.Progress.Queries.GetProgressByUserId
{
    public class GetProgressByUserIdQueryHandler
        : IRequestHandler<
            GetProgressByUserIdQuery,
            List<Domain.Entities.Progress>>
    {
        private readonly IUserDbContext _context;

        public GetProgressByUserIdQueryHandler(
            IUserDbContext context)
        {
            _context = context;
        }

        public async Task<List<Domain.Entities.Progress>> Handle(
            GetProgressByUserIdQuery request,
            CancellationToken cancellationToken)
        {
            return await _context.Progresses
                .Where(x => x.UserId == request.UserId)
                .ToListAsync(cancellationToken);
        }
    }
}