using FitnessAI.Domain.Entities;
using MediatR;

namespace FitnessAI.Application.Features.MealPlans.Queries.GetAllMealPlans
{
    public class GetAllMealPlansQuery
        : IRequest<List<MealPlan>>
    {
    }
}