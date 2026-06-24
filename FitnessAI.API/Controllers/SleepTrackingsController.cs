using FitnessAI.Application.Features.SleepTrackings.Commands.CreateSleepTracking;
using FitnessAI.Application.Features.SleepTrackings.Commands.UpdateSleepTracking;
using FitnessAI.Application.Features.SleepTrackings.Commands.DeleteSleepTracking;
using FitnessAI.Application.Features.SleepTrackings.Queries.GetAllSleepTrackings;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FitnessAI.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SleepTrackingsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SleepTrackingsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/SleepTrackings
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _mediator.Send(
                new GetAllSleepTrackingsQuery()));
        }

        // POST: api/SleepTrackings
        [HttpPost]
        public async Task<IActionResult> Create(
            CreateSleepTrackingCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        // PUT: api/SleepTrackings/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(
            int id,
            UpdateSleepTrackingCommand command)
        {
            command.Id = id;

            return Ok(await _mediator.Send(command));
        }

        // DELETE: api/SleepTrackings/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _mediator.Send(
                new DeleteSleepTrackingCommand
                {
                    Id = id
                }));
        }
    }
}