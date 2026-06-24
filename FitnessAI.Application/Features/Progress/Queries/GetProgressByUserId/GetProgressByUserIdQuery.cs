using MediatR;

namespace FitnessAI.Application.Features.Progress.Queries.GetProgressByUserId
{
    public class GetProgressByUserIdQuery
        : IRequest<List<Domain.Entities.Progress>>
    {
        public int UserId { get; set; }

        public GetProgressByUserIdQuery(int userId)
        {
            UserId = userId;
        }
    }
}