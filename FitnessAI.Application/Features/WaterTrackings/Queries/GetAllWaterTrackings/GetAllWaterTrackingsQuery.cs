using FitnessAI.Domain.Entities;
using MediatR;

namespace FitnessAI.Application.Features.WaterTrackings.Queries.GetAllWaterTrackings
{
    public class GetAllWaterTrackingsQuery
        : IRequest<List<WaterTracking>>
    {
    }
}