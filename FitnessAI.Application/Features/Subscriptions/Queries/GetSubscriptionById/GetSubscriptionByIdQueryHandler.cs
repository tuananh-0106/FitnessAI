using FitnessAI.Application.Common.Interfaces;
using FitnessAI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Application.Features.Subscriptions.Queries.GetSubscriptionById
{
    public class GetSubscriptionByIdQueryHandler
        : IRequestHandler<GetSubscriptionByIdQuery, Subscription?>
    {
        private readonly IUserDbContext _context;

        public GetSubscriptionByIdQueryHandler(
            IUserDbContext context)
        {
            _context = context;
        }

        public async Task<Subscription?> Handle(
            GetSubscriptionByIdQuery request,
            CancellationToken cancellationToken)
        {
            return await _context.Subscriptions
                .FirstOrDefaultAsync(
                    x => x.Id == request.Id,
                    cancellationToken);
        }
    }
}