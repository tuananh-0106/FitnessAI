using FitnessAI.Domain.Entities;
using MediatR;

namespace FitnessAI.Application.Features.Users.Queries.GetUserById
{
    public class GetUserByIdQuery
        : IRequest<User>
    {
        public int Id { get; set; }

        public GetUserByIdQuery(int id)
        {
            Id = id;
        }
    }
}