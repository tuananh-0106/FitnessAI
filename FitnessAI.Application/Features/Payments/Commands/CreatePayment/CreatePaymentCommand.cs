using MediatR;

namespace FitnessAI.Application.Features.Payments.Commands.CreatePayment
{
    public class CreatePaymentCommand : IRequest<int>
    {
        public int UserId { get; set; }

        public int SubscriptionId { get; set; }

        public decimal SoTien { get; set; }

        public string PhuongThucThanhToan { get; set; } = string.Empty;
    }
}