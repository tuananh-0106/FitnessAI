using FitnessAI.Application.Common.Interfaces;
using FitnessAI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Application.Features.Payments.Queries.GetUserPayments
{
    public class GetUserPaymentsQueryHandler
        : IRequestHandler<GetUserPaymentsQuery, List<Payment>>
    {
        private readonly IUserDbContext _context;

        public GetUserPaymentsQueryHandler(IUserDbContext context)
        {
            _context = context;
        }

        public async Task<List<Payment>> Handle(
            GetUserPaymentsQuery request,
            CancellationToken cancellationToken)
        {
            return await _context.Payments
                .Include(x => x.Subscription)
                .Where(x => x.UserId == request.UserId)
                .ToListAsync(cancellationToken);
        }
    }
}