using FitnessAI.Domain.Entities;
using MediatR;

namespace FitnessAI.Application.Features.WaterTrackings.Queries.GetWaterTrackingById
{
    public class GetWaterTrackingByIdQuery
        : IRequest<WaterTracking?>
    {
        public int Id { get; set; }

        public GetWaterTrackingByIdQuery(int id)
        {
            Id = id;
        }
    }
}