using FitnessAI.Application.Common.Interfaces;
using MediatR;

using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Application.Features.AIRecommendations.Commands.DeleteAIRecommendation
{
    public class DeleteAIRecommendationHandler
        : IRequestHandler<DeleteAIRecommendationCommand, bool>
    {
        private readonly IUserDbContext _context;

        public DeleteAIRecommendationHandler(IUserDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(
            DeleteAIRecommendationCommand request,
            CancellationToken cancellationToken)
        {
            var aiRecommendation = await _context.AIRecommendations
                .FirstOrDefaultAsync(x => x.Id == request.Id);

            if (aiRecommendation == null)
            {
                return false;
            }

            _context.AIRecommendations.Remove(aiRecommendation);

            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}