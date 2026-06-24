using FitnessAI.Domain.Entities;
using MediatR;

namespace FitnessAI.Application.Features.Subscriptions.Queries.GetSubscriptionByUserId
{
    public record GetSubscriptionByUserIdQuery(int UserId)
        : IRequest<List<Subscription>>;
}