using MediatR;

namespace FitnessAI.Application.Features.Users.Command.CreateUser
{
    public class CreateUserCommand : IRequest<int>
    {

        public string HoTen { get; set; } = string.Empty;

        public int Tuoi { get; set; }

        public string GioiTinh { get; set; } = string.Empty;

        public double ChieuCao { get; set; }

        public double CanNang { get; set; }

        public string MucTieu { get; set; } = string.Empty;
    }
}