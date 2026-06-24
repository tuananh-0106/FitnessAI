using FitnessAI.Application.Common.Interfaces;
using FitnessAI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Application.Features.AIRecommendations.Queries.GetAllAIRecommendations
{
    public class GetAllAIRecommendationsHandler
        : IRequestHandler<GetAllAIRecommendationsQuery, List<AIRecommendation>>
    {
        private readonly IUserDbContext _context;

        public GetAllAIRecommendationsHandler(IUserDbContext context)
        {
            _context = context;
        }

        public async Task<List<AIRecommendation>> Handle(
            GetAllAIRecommendationsQuery request,
            CancellationToken cancellationToken)
        {
            return await _context.AIRecommendations
                .ToListAsync(cancellationToken);
        }
    }
}