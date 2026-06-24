using MediatR;

namespace FitnessAI.Application.Features.WaterTrackings.Commands.DeleteWaterTracking
{
    public class DeleteWaterTrackingCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}