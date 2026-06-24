using FitnessAI.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Application.Features.Subscriptions.Commands.DeleteSubscription
{
    public class DeleteSubscriptionCommandHandler
        : IRequestHandler<DeleteSubscriptionCommand, bool>
    {
        private readonly IUserDbContext _context;

        public DeleteSubscriptionCommandHandler(
            IUserDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(
            DeleteSubscriptionCommand request,
            CancellationToken cancellationToken)
        {
            var subscription = await _context.Subscriptions
                .FirstOrDefaultAsync(
                    x => x.Id == request.Id,
                    cancellationToken);

            if (subscription == null)
            {
                return false;
            }

            _context.Subscriptions.Remove(subscription);

            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}