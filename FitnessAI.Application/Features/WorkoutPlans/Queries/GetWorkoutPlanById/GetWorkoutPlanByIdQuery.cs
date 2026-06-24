using FitnessAI.Domain.Entities;
using MediatR;

namespace FitnessAI.Application.Features.WorkoutPlans.Queries.GetWorkoutPlanById
{
    public class GetWorkoutPlanByIdQuery
        : IRequest<WorkoutPlan?>
    {
        public int Id { get; set; }

        public GetWorkoutPlanByIdQuery(int id)
        {
            Id = id;
        }
    }
}