using FitnessAI.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Application.Features.Users.Commands.UpdateUser
{
    public class UpdateUserCommandHandler
        : IRequestHandler<UpdateUserCommand, bool>
    {
        private readonly IUserDbContext _context;

        public UpdateUserCommandHandler(
            IUserDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(
            UpdateUserCommand request,
            CancellationToken cancellationToken)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(
                    x => x.Id == request.Id,
                    cancellationToken);

            if (user == null)
            {
                return false;
            }

            double bmi = request.CanNang /
                Math.Pow(request.ChieuCao / 100, 2);

            user.HoTen = request.HoTen;
            user.Tuoi = request.Tuoi;
            user.GioiTinh = request.GioiTinh;
            user.ChieuCao = request.ChieuCao;
            user.CanNang = request.CanNang;
            user.BMI = Math.Round(bmi, 2);
            user.MucTieu = request.MucTieu;

            _context.Users.Update(user);

            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}