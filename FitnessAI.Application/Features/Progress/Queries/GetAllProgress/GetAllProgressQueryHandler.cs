using FitnessAI.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Application.Features.Progress.Queries.GetAllProgress
{
    public class GetAllProgressQueryHandler
        : IRequestHandler<
            GetAllProgressQuery,
            List<Domain.Entities.Progress>>
    {
        private readonly IUserDbContext _context;

        public GetAllProgressQueryHandler(
            IUserDbContext context)
        {
            _context = context;
        }

        public async Task<List<Domain.Entities.Progress>> Handle(
            GetAllProgressQuery request,
            CancellationToken cancellationToken)
        {
            return await _context.Progresses
                .ToListAsync(cancellationToken);
        }
    }
}