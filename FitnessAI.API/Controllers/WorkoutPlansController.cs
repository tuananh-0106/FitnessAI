using FitnessAI.Application.Features.WorkoutPlans.Commands.CreateWorkoutPlan;
using FitnessAI.Application.Features.WorkoutPlans.Queries.GetAllWorkoutPlans;
using FitnessAI.Application.Features.WorkoutPlans.Queries.GetWorkoutPlanById;
using FitnessAI.Application.Features.WorkoutPlans.Commands.UpdateWorkoutPlan;
using FitnessAI.Application.Features.WorkoutPlans.Commands.DeleteWorkoutPlan;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FitnessAI.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WorkoutPlansController : ControllerBase
    {
        private readonly IMediator _mediator;

        public WorkoutPlansController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetAllWorkoutPlansQuery());

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _mediator.Send(
                new GetWorkoutPlanByIdQuery(id));

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(
            CreateWorkoutPlanCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(
            UpdateWorkoutPlanCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _mediator.Send(
                new DeleteWorkoutPlanCommand(id));

            return Ok(result);
        }
    }
}