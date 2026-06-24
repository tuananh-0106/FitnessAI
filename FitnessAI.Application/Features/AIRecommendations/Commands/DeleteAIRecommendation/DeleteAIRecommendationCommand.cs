using MediatR;

namespace FitnessAI.Application.Features.AIRecommendations.Commands.DeleteAIRecommendation
{
    public class DeleteAIRecommendationCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}