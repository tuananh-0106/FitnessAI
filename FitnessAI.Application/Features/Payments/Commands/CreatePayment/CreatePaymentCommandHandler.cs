using FitnessAI.Application.Common.Interfaces;
using FitnessAI.Domain.Entities;
using FitnessAI.Domain.Enums;
using MediatR;

namespace FitnessAI.Application.Features.Payments.Commands.CreatePayment
{
    public class CreatePaymentCommandHandler
        : IRequestHandler<CreatePaymentCommand, int>
    {
        private readonly IUserDbContext _context;

        public CreatePaymentCommandHandler(IUserDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(
            CreatePaymentCommand request,
            CancellationToken cancellationToken)
        {
            var payment = new Payment
            {
                UserId = request.UserId,
                SubscriptionId = request.SubscriptionId,
                SoTien = request.SoTien,
                PhuongThucThanhToan = request.PhuongThucThanhToan,
                TrangThai = PaymentStatus.Pending,
                MaGiaoDich = Guid.NewGuid().ToString(),
                NgayThanhToan = DateTime.UtcNow
            };

            _context.Payments.Add(payment);

            await _context.SaveChangesAsync(cancellationToken);

            return payment.Id;
        }
    }
}