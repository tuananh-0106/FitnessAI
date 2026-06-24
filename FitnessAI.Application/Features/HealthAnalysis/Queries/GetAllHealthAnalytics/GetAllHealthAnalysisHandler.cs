using FitnessAI.Application.Common.Interfaces;
using FitnessAI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace FitnessAI.Application.Features.HealthAnalysis.Queries.GetAllHealthAnalytics
{
    public class GetAllHealthAnalysisHandler
        : IRequestHandler<GetAllHealthAnalysisQuery, List<HealthAnalysisEntity>>
    {
        private readonly IUserDbContext _context;

        public GetAllHealthAnalysisHandler(IUserDbContext context)
        {
            _context = context;
        }

        public async Task<List<HealthAnalysisEntity>> Handle(
            GetAllHealthAnalysisQuery request,
            CancellationToken cancellationToken)
        {
            return await _context.HealthAnalysisEntity.ToListAsync();
        }
    }
}