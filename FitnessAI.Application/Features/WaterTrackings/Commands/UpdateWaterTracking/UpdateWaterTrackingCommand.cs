using MediatR;

namespace FitnessAI.Application.Features.WaterTrackings.Commands.UpdateWaterTracking
{
    public class UpdateWaterTrackingCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public double LuongNuocML { get; set; }
    }
}