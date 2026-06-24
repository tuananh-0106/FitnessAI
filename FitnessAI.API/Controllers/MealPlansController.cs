using MediatR;
using Microsoft.AspNetCore.Mvc;
using FitnessAI.Application.Features.MealPlans.Queries.GetAllMealPlans;
using FitnessAI.Application.Features.MealPlans.Commands.CreateMealPlan;
using FitnessAI.Application.Features.MealPlans.Queries.GetMealPlanById;
using FitnessAI.Application.Features.MealPlans.Commands.UpdateMealPlan;
using FitnessAI.Application.Features.MealPlans.Commands.DeleteMealPlan;

namespace FitnessAI.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MealPlansController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MealPlansController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(
                new GetAllMealPlansQuery());

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _mediator.Send(
                new GetMealPlanByIdQuery(id));

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(
            CreateMealPlanCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpPut("{userId}")]
        public async Task<IActionResult> Update(
            int userId,
            UpdateMealPlanCommand command)
        {
            command.UserId = userId;

            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _mediator.Send(
                new DeleteMealPlanCommand(id));

            return Ok(result);
        }
    }
}