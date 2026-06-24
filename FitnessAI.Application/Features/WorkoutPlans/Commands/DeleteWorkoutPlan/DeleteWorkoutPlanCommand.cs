using MediatR;

namespace FitnessAI.Application.Features.WorkoutPlans.Commands.DeleteWorkoutPlan
{
    public class DeleteWorkoutPlanCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public DeleteWorkoutPlanCommand(int id)
        {
            Id = id;
        }
    }
}