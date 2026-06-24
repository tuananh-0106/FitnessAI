using MediatR;

namespace FitnessAI.Application.Features.HealthAnalysis.Commands.CreateHealthAnalytics
{
    public class CreateHealthAnalysisCommand : IRequest<int>
    {
        public int UserId { get; set; }

        public double ChieuCao { get; set; }

        public double CanNang { get; set; }

        public double BodyFat { get; set; }
    }
}