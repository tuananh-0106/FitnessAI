using FitnessAI.Application.Features.Subscriptions.Commands.CreateSubscription;
using FitnessAI.Application.Features.Subscriptions.Commands.UpdateSubscription;
using FitnessAI.Application.Features.Subscriptions.Commands.DeleteSubscription;

using FitnessAI.Application.Features.Subscriptions.Queries.GetAllSubscription;
using FitnessAI.Application.Features.Subscriptions.Queries.GetSubscriptionById;
using FitnessAI.Application.Features.Subscriptions.Queries.GetSubscriptionByUserId;

using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FitnessAI.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubscriptionController(IMediator mediator)
        : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        // =========================
        // GET ALL
        // =========================

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(
                new GetAllSubscriptionQuery());

            return Ok(result);
        }

        // =========================
        // GET BY ID
        // =========================

        [HttpGet("detail/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _mediator.Send(
                new GetSubscriptionByIdQuery(id));

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // =========================
        // GET BY USER ID
        // =========================

        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetByUser(int userId)
        {
            var result = await _mediator.Send(
                new GetSubscriptionByUserIdQuery(userId));

            return Ok(result);
        }

        // =========================
        // CREATE
        // =========================

        [HttpPost]
        public async Task<IActionResult> Create(
            CreateSubscriptionCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        // =========================
        // UPDATE
        // =========================

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(
            int id,
            UpdateSubscriptionCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }

            var result = await _mediator.Send(command);

            if (!result)
            {
                return NotFound();
            }

            return Ok("Update successful");
        }

        // =========================
        // DELETE
        // =========================

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _mediator.Send(
                new DeleteSubscriptionCommand
                {
                    Id = id
                });

            if (!result)
            {
                return NotFound();
            }

            return Ok("Delete successful");
        }
    }
}