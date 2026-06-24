using MediatR;

namespace FitnessAI.Application.Features.Payments.Commands.ConfirmPayment
{
    public class ConfirmPaymentCommand : IRequest<bool>
    {
        public int Id { get; set; }

        
    }
}