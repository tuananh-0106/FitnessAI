using MediatR;

namespace FitnessAI.Application.Features.HealthAnalysis.Commands.UpdateHealthAnalytics
{
    public class UpdateHealthAnalysisCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public double ChieuCao { get; set; }

        public double CanNang { get; set; }

        public double BodyFat { get; set; }
    }
}