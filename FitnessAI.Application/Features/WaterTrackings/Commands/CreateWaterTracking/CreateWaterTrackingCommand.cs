using MediatR;

namespace FitnessAI.Application.Features.WaterTrackings.Commands.CreateWaterTracking
{
    public class CreateWaterTrackingCommand : IRequest<int>
    {
        public int UserId { get; set; }

        public double LuongNuocML { get; set; }
    }
}