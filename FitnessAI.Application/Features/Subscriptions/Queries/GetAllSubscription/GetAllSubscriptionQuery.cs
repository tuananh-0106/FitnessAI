using FitnessAI.Domain.Entities;
using MediatR;

namespace FitnessAI.Application.Features.Subscriptions.Queries.GetAllSubscription
{
    public record GetAllSubscriptionQuery
        : IRequest<List<Subscription>>;
}