using FitnessAI.Application.Common.Interfaces;
using FitnessAI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Application.Features.Subscriptions.Queries.GetSubscriptionByUserId
{
    public class GetSubscriptionByUserIdQueryHandler
        : IRequestHandler<GetSubscriptionByUserIdQuery, List<Subscription>>
    {
        private readonly IUserDbContext _context;

        public GetSubscriptionByUserIdQueryHandler(
            IUserDbContext context)
        {
            _context = context;
        }

        public async Task<List<Subscription>> Handle(
            GetSubscriptionByUserIdQuery request,
            CancellationToken cancellationToken)
        {
            return await _context.Subscriptions
                .Where(x => x.UserId == request.UserId)
                .ToListAsync(cancellationToken);
        }
    }
}