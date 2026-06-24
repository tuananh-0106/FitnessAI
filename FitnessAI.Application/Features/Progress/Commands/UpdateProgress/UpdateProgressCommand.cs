using MediatR;

namespace FitnessAI.Application.Features.Progress.Commands.UpdateProgress
{
    public class UpdateProgressCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public double CanNang { get; set; }

        public double ChieuCao { get; set; }

        public double MoCoThe { get; set; }

        public double KhoiLuongCo { get; set; }

        public double CaloriesDotChay { get; set; }

        public string GhiChu { get; set; } = string.Empty;

        public int UserId { get; set; }
    }
}