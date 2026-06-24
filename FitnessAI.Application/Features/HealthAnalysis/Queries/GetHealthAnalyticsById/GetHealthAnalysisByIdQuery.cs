using FitnessAI.Domain.Entities;
using MediatR;

public class GetHealthAnalysisByIdQuery
    : IRequest<HealthAnalysisEntity?>
{
    public int Id { get; set; }

    public GetHealthAnalysisByIdQuery(int id)
    {
        Id = id;
    }
}