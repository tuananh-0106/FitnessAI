using MediatR;

namespace FitnessAI.Application.Features.Progress.Commands.CreateProgress
{
    public class CreateProgressCommand : IRequest<int>
    {
        public double CanNang { get; set; }

        public double ChieuCao { get; set; }

        public double MoCoThe { get; set; }

        public double KhoiLuongCo { get; set; }

        public int CaloriesDotChay { get; set; }

        public string GhiChu { get; set; } = string.Empty;

        public int UserId { get; set; }
    }
}