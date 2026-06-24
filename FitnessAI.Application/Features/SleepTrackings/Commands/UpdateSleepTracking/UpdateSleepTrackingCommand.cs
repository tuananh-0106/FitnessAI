using MediatR;

namespace FitnessAI.Application.Features.SleepTrackings.Commands.UpdateSleepTracking
{
    public class UpdateSleepTrackingCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public DateTime GioBatDauNgu { get; set; }

        public DateTime GioThucDay { get; set; }

        public string ChatLuongNgu { get; set; } = string.Empty;

        public string GhiChu { get; set; } = string.Empty;
    }
}