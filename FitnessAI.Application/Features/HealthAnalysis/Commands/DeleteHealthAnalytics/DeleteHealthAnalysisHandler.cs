using FitnessAI.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace FitnessAI.Application.Features.HealthAnalysis.Commands.DeleteHealthAnalytics
{
    public class DeleteHealthAnalysisHandler
        : IRequestHandler<DeleteHealthAnalysisCommand, bool>
    {
        private readonly IUserDbContext _context;

        public DeleteHealthAnalysisHandler(IUserDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(
            DeleteHealthAnalysisCommand request,
            CancellationToken cancellationToken)
        {
            var health = await _context.HealthAnalysisEntity
                .FirstOrDefaultAsync(x => x.Id == request.Id);

            if (health == null)
            {
                return false;
            }

            _context.HealthAnalysisEntity.Remove(health);

            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}