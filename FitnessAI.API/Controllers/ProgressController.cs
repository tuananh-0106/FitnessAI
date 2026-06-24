using FitnessAI.Application.Features.Progress.Commands.CreateProgress;
using FitnessAI.Application.Features.Progress.Commands.UpdateProgress;
using FitnessAI.Application.Features.Progress.Commands.DeleteProgress;

using FitnessAI.Application.Features.Progress.Queries.GetAllProgress;
using FitnessAI.Application.Features.Progress.Queries.GetProgressByUserId;

using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FitnessAI.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProgressController(IMediator mediator)
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
                new GetAllProgressQuery());

            return Ok(result);
        }

        // =========================
        // GET BY ID
        // =========================

        [HttpGet("detail/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _mediator.Send(
                new GetProgressByUserIdQuery(id));

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // =========================
        // GET BY USER ID
        // =========================

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetByUser(int userId)
        {
            var result = await _mediator.Send(
                new GetProgressByUserIdQuery(userId));

            return Ok(result);
        }

        // =========================
        // CREATE
        // =========================

        [HttpPost]
        public async Task<IActionResult> Create(
            CreateProgressCommand command)
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
            UpdateProgressCommand command)
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
                new DeleteProgressCommand
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