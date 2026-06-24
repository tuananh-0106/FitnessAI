using FitnessAI.Application.Common.Interfaces;
using FitnessAI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Application.Features.AIRecommendations.Queries.GetAIRecommendationById
{
    public class GetAIRecommendationByIdHandler
        : IRequestHandler<GetAIRecommendationByIdQuery, AIRecommendation?>
    {
        private readonly IUserDbContext _context;

        public GetAIRecommendationByIdHandler(IUserDbContext context)
        {
            _context = context;
        }

        public async Task<AIRecommendation?> Handle(
            GetAIRecommendationByIdQuery request,
            CancellationToken cancellationToken)
        {
            return await _context.AIRecommendations
                .FirstOrDefaultAsync(x => x.Id == request.Id,
                cancellationToken);
        }
    }
}