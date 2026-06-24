using FitnessAI.Domain.Entities;
using MediatR;

namespace FitnessAI.Application.Features.SleepTrackings.Queries.GetSleepTrackingById
{
    public class GetSleepTrackingByIdQuery
        : IRequest<SleepTracking?>
    {
        public int Id { get; set; }

        public GetSleepTrackingByIdQuery(int id)
        {
            Id = id;
        }
    }
}