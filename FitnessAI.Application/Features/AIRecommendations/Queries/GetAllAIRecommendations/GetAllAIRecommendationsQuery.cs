using MediatR;
using FitnessAI.Domain.Entities;

namespace FitnessAI.Application.Features.AIRecommendations.Queries.GetAllAIRecommendations
{
    public class GetAllAIRecommendationsQuery
        : IRequest<List<AIRecommendation>>
    {
    }
}