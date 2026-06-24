using FitnessAI.Domain.Entities;
using MediatR;

namespace FitnessAI.Application.Features.SleepTrackings.Queries.GetAllSleepTrackings
{
    public class GetAllSleepTrackingsQuery
        : IRequest<List<SleepTracking>>
    {
    }
}