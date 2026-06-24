using FitnessAI.Application.Common.Interfaces;
using FitnessAI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Application.Features.Payments.Queries.GetPaymentById
{
    public class GetPaymentByIdQueryHandler
        : IRequestHandler<GetPaymentByIdQuery, Payment?>
    {
        private readonly IUserDbContext _context;

        public GetPaymentByIdQueryHandler(IUserDbContext context)
        {
            _context = context;
        }

        public async Task<Payment?> Handle(
            GetPaymentByIdQuery request,
            CancellationToken cancellationToken)
        {
            return await _context.Payments
                .Include(x => x.User)
                .Include(x => x.Subscription)
                .FirstOrDefaultAsync(
                    x => x.Id == request.Id,
                    cancellationToken);
        }
    }
}