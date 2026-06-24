using FitnessAI.Application.Common.Interfaces;
using FitnessAI.Domain.Entities;
using MediatR;

namespace FitnessAI.Application.Features.Payments.Queries.GetAllPayments
{
    public class GetAllPaymentsQueryHandler
        : IRequestHandler<GetAllPaymentsQuery, List<Payment>>
    {
        private readonly IUserDbContext _context;

        public GetAllPaymentsQueryHandler(
            IUserDbContext context)
        {
            _context = context;
        }

        public async Task<List<Payment>> Handle(
            GetAllPaymentsQuery request,
            CancellationToken cancellationToken)
        {
            return _context.Payments.ToList();
        }
    }
}