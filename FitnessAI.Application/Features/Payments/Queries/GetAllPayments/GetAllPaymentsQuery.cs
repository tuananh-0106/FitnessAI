using MediatR;
using FitnessAI.Domain.Entities;

namespace FitnessAI.Application.Features.Payments.Queries.GetAllPayments
{
    public record GetAllPaymentsQuery()
        : IRequest<List<Payment>>;
}