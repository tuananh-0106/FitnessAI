using MediatR;
using FitnessAI.Domain.Entities;

namespace FitnessAI.Application.Features.HealthAnalysis.Queries.GetAllHealthAnalytics
{
    public class GetAllHealthAnalysisQuery
        : IRequest<List<HealthAnalysisEntity>>
    {
    }
}