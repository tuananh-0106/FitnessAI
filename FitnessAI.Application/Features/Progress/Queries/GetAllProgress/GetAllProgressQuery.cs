using FitnessAI.Domain.Entities;
using MediatR;

namespace FitnessAI.Application.Features.Progress.Queries.GetAllProgress
{
    public class GetAllProgressQuery
        : IRequest<List<Domain.Entities.Progress>>
    {
    }
}