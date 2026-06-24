using FitnessAI.Domain.Entities;
using MediatR;

namespace FitnessAI.Application.Features.Subscriptions.Queries.GetSubscriptionById
{
    public record GetSubscriptionByIdQuery(int Id)
        : IRequest<Subscription?>;
}