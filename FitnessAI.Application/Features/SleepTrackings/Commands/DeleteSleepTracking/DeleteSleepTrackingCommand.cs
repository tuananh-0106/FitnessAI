using MediatR;

namespace FitnessAI.Application.Features.SleepTrackings.Commands.DeleteSleepTracking
{
    public class DeleteSleepTrackingCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}