using FitnessAI.Application.Common.Interfaces;
using FitnessAI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Application.Features.Users.Queries.GetUserById
{
    public class GetUserByIdQueryHandler
        : IRequestHandler<GetUserByIdQuery, User>
    {
        private readonly IUserDbContext _context;

        public GetUserByIdQueryHandler(
            IUserDbContext context)
        {
            _context = context;
        }

        public async Task<User> Handle(
            GetUserByIdQuery request,
            CancellationToken cancellationToken)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(
                    x => x.Id == request.Id,
                    cancellationToken);

            return user!;
        }
    }
}