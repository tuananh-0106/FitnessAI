using FitnessAI.Application.Common.Interfaces;
using FitnessAI.Domain.Entities;
using MediatR;

namespace FitnessAI.Application.Features.Users.Command.CreateUser
{
    public class CreateUserCommandHandler(
     IUserDbContext context)
     : IRequestHandler<CreateUserCommand, int>
    {
        private readonly IUserDbContext _context = context;
        


        public async Task<int> Handle(
            CreateUserCommand request,
            CancellationToken cancellationToken)
        {
            var user = new User
            {
                HoTen = request.HoTen,
                Tuoi = request.Tuoi,
                GioiTinh = request.GioiTinh,
                ChieuCao = request.ChieuCao,
                CanNang = request.CanNang,
                MucTieu = request.MucTieu,
                NgayTao = DateTime.Now
            };

            await _context.Users.AddAsync(user);

            await _context.SaveChangesAsync(
                cancellationToken);

            return user.Id;
        }
    }
}