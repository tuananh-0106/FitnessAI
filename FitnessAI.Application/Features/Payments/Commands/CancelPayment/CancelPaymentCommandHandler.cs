using FitnessAI.Application.Common.Interfaces;
using FitnessAI.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Application.Features.Payments.Commands.CancelPayment
{
    public class CancelPaymentCommandHandler
        : IRequestHandler<CancelPaymentCommand, bool>
    {
        private readonly IUserDbContext _context;

        public CancelPaymentCommandHandler(IUserDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(
            CancelPaymentCommand request,
            CancellationToken cancellationToken)
        {
            var payment = await _context.Payments
                .FirstOrDefaultAsync(
                    x => x.Id == request.Id,
                    cancellationToken);

            if (payment == null)
                return false;

            payment.TrangThai = PaymentStatus.Cancelled;

            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}