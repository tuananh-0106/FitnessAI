using FitnessAI.Domain.Entities;
using MediatR;

namespace FitnessAI.Application.Features.WorkoutPlans.Queries.GetAllWorkoutPlans
{
    public class GetAllWorkoutPlansQuery
        : IRequest<List<WorkoutPlan>>
    {
    }
}