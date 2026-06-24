using FitnessAI.Application.Common.Interfaces;
using FitnessAI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace FitnessAI.Application.Features.HealthAnalysis.Queries.GetHealthAnalyticsById
{
    public class GetHealthAnalysisByIdHandler
        : IRequestHandler<GetHealthAnalysisByIdQuery, HealthAnalysisEntity?>
    {
        private readonly IUserDbContext _context;

        public GetHealthAnalysisByIdHandler(IUserDbContext context)
        {
            _context = context;
        }

        public async Task<HealthAnalysisEntity?> Handle(
            GetHealthAnalysisByIdQuery request,
            CancellationToken cancellationToken)
        {
            return await _context.HealthAnalysisEntity
                .FirstOrDefaultAsync(x => x.Id == request.Id);
        }
    }
}