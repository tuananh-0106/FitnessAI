using MediatR;

namespace FitnessAI.Application.Features.HealthAnalysis.Commands.DeleteHealthAnalytics
{
    public class DeleteHealthAnalysisCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}