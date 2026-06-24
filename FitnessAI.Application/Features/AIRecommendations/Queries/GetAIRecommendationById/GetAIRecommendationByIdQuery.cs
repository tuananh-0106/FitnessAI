using MediatR;
using FitnessAI.Domain.Entities;

namespace FitnessAI.Application.Features.AIRecommendations.Queries.GetAIRecommendationById
{
    public class GetAIRecommendationByIdQuery
        : IRequest<AIRecommendation?>
    {
        public int Id { get; set; }
    }
}