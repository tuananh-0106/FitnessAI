using FitnessAI.Application.Features.AIRecommendations.Commands.CreateAIRecommendation;
using FitnessAI.Application.Features.AIRecommendations.Commands.UpdateAIRecommendation;
using FitnessAI.Application.Features.AIRecommendations.Commands.DeleteAIRecommendation;
using FitnessAI.Application.Features.AIRecommendations.Queries.GetAllAIRecommendations;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FitnessAI.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AIRecommendationsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AIRecommendationsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/AIRecommendations
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _mediator.Send(
                new GetAllAIRecommendationsQuery()));
        }

        // POST: api/AIRecommendations
        [HttpPost]
        public async Task<IActionResult> Create(
            CreateAIRecommendationCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        // PUT: api/AIRecommendations/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(
            int id,
            UpdateAIRecommendationCommand command)
        {
            command.Id = id;

            return Ok(await _mediator.Send(command));
        }

        // DELETE: api/AIRecommendations/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _mediator.Send(
                new DeleteAIRecommendationCommand
                {
                    Id = id
                }));
        }
    }
}