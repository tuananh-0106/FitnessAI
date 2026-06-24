using FitnessAI.Application.Common.Interfaces;
using FitnessAI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Application.Features.Users.Queries.GetAllUsers
{
    public class GetAllUsersQueryHandler
        : IRequestHandler<GetAllUsersQuery, List<User>>
    {
        private readonly IUserDbContext _context;

        public GetAllUsersQueryHandler(
            IUserDbContext context)
        {
            _context = context;
        }

        public async Task<List<User>> Handle(
            GetAllUsersQuery request,
            CancellationToken cancellationToken)
        {
            return await _context.Users
                .OrderByDescending(x => x.NgayTao)
                .ToListAsync(cancellationToken);
        }
    }
}