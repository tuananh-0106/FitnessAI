using MediatR;

namespace FitnessAI.Application.Features.Payments.Commands.CancelPayment
{
    public class CancelPaymentCommand : IRequest<bool>
    {
        public int Id { get; set; }


    }
}