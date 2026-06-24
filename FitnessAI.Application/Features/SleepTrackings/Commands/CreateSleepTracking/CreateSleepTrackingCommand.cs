using MediatR;

namespace FitnessAI.Application.Features.SleepTrackings.Commands.CreateSleepTracking
{
    public class CreateSleepTrackingCommand : IRequest<int>
    {
        public int UserId { get; set; }

        public DateTime GioBatDauNgu { get; set; }

        public DateTime GioThucDay { get; set; }

        public string ChatLuongNgu { get; set; } = string.Empty;

        public string GhiChu { get; set; } = string.Empty;
    }
}