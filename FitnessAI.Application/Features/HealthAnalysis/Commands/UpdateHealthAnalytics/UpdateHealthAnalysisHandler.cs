using FitnessAI.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Application.Features.HealthAnalysis.Commands.UpdateHealthAnalytics
{
    public class UpdateHealthAnalysisHandler
        : IRequestHandler<UpdateHealthAnalysisCommand, bool>
    {
        private readonly IUserDbContext _context;

        public UpdateHealthAnalysisHandler(IUserDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(
            UpdateHealthAnalysisCommand request,
            CancellationToken cancellationToken)
        {
            var health = await _context.HealthAnalysisEntity
                .FirstOrDefaultAsync(x => x.Id == request.Id);

            if (health == null)
            {
                return false;
            }

            health.ChieuCao = request.ChieuCao;
            health.CanNang = request.CanNang;
            health.BodyFat = request.BodyFat;

            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}