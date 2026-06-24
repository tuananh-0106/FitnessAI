using FitnessAI.Domain.Entities;
using MediatR;

namespace FitnessAI.Application.Features.MealPlans.Queries.GetMealPlanById
{
    public class GetMealPlanByIdQuery
        : IRequest<MealPlan?>
    {
        public int Id { get; set; }

        public GetMealPlanByIdQuery(int id)
        {
            Id = id;
        }
    }
}