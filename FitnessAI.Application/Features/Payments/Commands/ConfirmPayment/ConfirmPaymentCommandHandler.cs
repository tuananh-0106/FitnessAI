using FitnessAI.Application.Common.Interfaces;
using FitnessAI.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Application.Features.Payments.Commands.ConfirmPayment
{
    public class ConfirmPaymentCommandHandler
        : IRequestHandler<ConfirmPaymentCommand, bool>
    {
        private readonly IUserDbContext _context;

        public ConfirmPaymentCommandHandler(IUserDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(
            ConfirmPaymentCommand request,
            CancellationToken cancellationToken)
        {
            var payment = await _context.Payments
                .FirstOrDefaultAsync(
                    x => x.Id == request.Id,
                    cancellationToken);

            if (payment == null)
                return false;

            payment.TrangThai = PaymentStatus.Paid;

            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}