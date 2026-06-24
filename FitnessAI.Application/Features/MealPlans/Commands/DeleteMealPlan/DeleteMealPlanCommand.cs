using MediatR;

namespace FitnessAI.Application.Features.MealPlans.Commands.DeleteMealPlan
{
    public class DeleteMealPlanCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public DeleteMealPlanCommand(int id)
        {
            Id = id;
        }
    }
}