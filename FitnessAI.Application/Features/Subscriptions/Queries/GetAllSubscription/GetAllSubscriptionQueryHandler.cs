using FitnessAI.Application.Common.Interfaces;
using FitnessAI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Application.Features.Subscriptions.Queries.GetAllSubscription
{
    public class GetAllSubscriptionQueryHandler
        : IRequestHandler<GetAllSubscriptionQuery, List<Subscription>>
    {
        private readonly IUserDbContext _context;

        public GetAllSubscriptionQueryHandler(
            IUserDbContext context)
        {
            _context = context;
        }

        public async Task<List<Subscription>> Handle(
            GetAllSubscriptionQuery request,
            CancellationToken cancellationToken)
        {
            return await _context.Subscriptions
                .ToListAsync(cancellationToken);
        }
    }
}