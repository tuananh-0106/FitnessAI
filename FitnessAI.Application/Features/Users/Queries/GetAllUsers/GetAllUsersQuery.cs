using FitnessAI.Domain.Entities;
using MediatR;

namespace FitnessAI.Application.Features.Users.Queries.GetAllUsers
{
    public class GetAllUsersQuery
        : IRequest<List<User>>
    {
    }
}