using FitnessAI.Application.Features.Foods.Commands.CreateFood;
using FitnessAI.Application.Features.Foods.Commands.UpdateFood;
using FitnessAI.Application.Features.Foods.Commands.DeleteFood;
using FitnessAI.Application.Features.Foods.Queries.GetAllFoods;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FitnessAI.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FoodsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FoodsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _mediator.Send(new GetAllFoodsQuery()));
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateFoodCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(
            int id,
            UpdateFoodCommand command)
        {
            command.Id = id;
            return Ok(await _mediator.Send(command));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _mediator.Send(
                new DeleteFoodCommand
                {
                    Id = id
                }));
        }
    }
}