using FitnessAI.Domain.Entities;
using MediatR;

namespace FitnessAI.Application.Features.Payments.Queries.GetUserPayments
{
    public class GetUserPaymentsQuery : IRequest<List<Payment>>
    {
        public int UserId { get; set; }

        public GetUserPaymentsQuery(int userId)
        {
            UserId = userId;
        }
    }
}