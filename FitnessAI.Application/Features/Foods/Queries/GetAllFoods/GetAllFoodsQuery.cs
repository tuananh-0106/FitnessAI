using MediatR;
using FitnessAI.Domain.Entities;

namespace FitnessAI.Application.Features.Foods.Queries.GetAllFoods
{
    public class GetAllFoodsQuery : IRequest<List<Food>>
    {
    }
}