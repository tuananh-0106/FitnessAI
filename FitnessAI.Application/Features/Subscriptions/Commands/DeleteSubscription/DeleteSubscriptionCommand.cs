using MediatR;

namespace FitnessAI.Application.Features.Subscriptions.Commands.DeleteSubscription
{
    public class DeleteSubscriptionCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}