using FitnessAI.Application.Features.WaterTrackings.Commands.CreateWaterTracking;
using FitnessAI.Application.Features.WaterTrackings.Commands.UpdateWaterTracking;
using FitnessAI.Application.Features.WaterTrackings.Commands.DeleteWaterTracking;
using FitnessAI.Application.Features.WaterTrackings.Queries.GetAllWaterTrackings;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FitnessAI.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WaterTrackingsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public WaterTrackingsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/WaterTrackings
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _mediator.Send(
                new GetAllWaterTrackingsQuery()));
        }

        // POST: api/WaterTrackings
        [HttpPost]
        public async Task<IActionResult> Create(
            CreateWaterTrackingCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        // PUT: api/WaterTrackings/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(
            int id,
            UpdateWaterTrackingCommand command)
        {
            command.Id = id;

            return Ok(await _mediator.Send(command));
        }

        // DELETE: api/WaterTrackings/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _mediator.Send(
                new DeleteWaterTrackingCommand
                {
                    Id = id
                }));
        }
    }
}