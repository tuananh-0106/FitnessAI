using MediatR;
using FitnessAI.Domain.Entities;

namespace FitnessAI.Application.Features.Foods.Queries.GetFoodById
{
    public class GetFoodByIdQuery : IRequest<Food?>
    {
        public int Id { get; set; }

        public GetFoodByIdQuery(int id)
        {
            Id = id;
        }
    }
}