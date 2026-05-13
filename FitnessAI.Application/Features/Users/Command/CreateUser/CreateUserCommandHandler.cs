using FitnessAI.Application.Interfaces;
using FitnessAI.Domain.Entities;
using MediatR;

namespace FitnessAI.Application.Features.Users.Command.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly IUserRepository _userRepository;

        public CreateUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            double bmi = request.CanNang / Math.Pow(request.ChieuCao / 100, 2);

            var user = new User
            {
                HoTen = request.HoTen,
                Tuoi = request.Tuoi,
                GioiTinh = request.GioiTinh,
                ChieuCao = request.ChieuCao,
                CanNang = request.CanNang,
                BMI = Math.Round(bmi, 2),
                MucTieu = request.MucTieu
            };

            await _userRepository.AddAsync(user);

            return user.Id;
        }
    }
}