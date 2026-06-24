using FitnessAI.Domain.Entities;
using FitnessAI.Application.Common.Interfaces;
using MediatR;


namespace FitnessAI.Application.Features.Auth.Commands.Register
{
    public class RegisterCommandHandler
        : IRequestHandler<RegisterCommand, int>
    {
        private readonly IUserDbContext _context;

        public RegisterCommandHandler(
            IUserDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(
            RegisterCommand request,
            CancellationToken cancellationToken)
        {
            double bmi = request.CanNang /
                Math.Pow(request.ChieuCao / 100, 2);

            var user = new User
            {
                HoTen = request.HoTen,
                Tuoi = request.Tuoi,
                GioiTinh = request.GioiTinh,
                ChieuCao = request.ChieuCao,
                CanNang = request.CanNang,
                BMI = Math.Round(bmi, 2),
                MucTieu = request.MucTieu,
                NgayTao = DateTime.Now,
                Email = request.Email,
                PasswordHash = (request.Password),
                Role = "User"
            };

            _context.Users.Add(user);

            await _context.SaveChangesAsync(cancellationToken);

            return user.Id;
        }
    }
}