using FitnessAI.Application.Features.HealthAnalysis.Commands.CreateHealthAnalytics;
using FitnessAI.Application.Features.HealthAnalysis.Commands.DeleteHealthAnalytics;
using FitnessAI.Application.Features.HealthAnalysis.Commands.UpdateHealthAnalytics;
using FitnessAI.Application.Features.HealthAnalysis.Queries.GetAllHealthAnalytics;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FitnessAI.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthAnalyticsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public HealthAnalyticsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _mediator.Send(new GetAllHealthAnalysisQuery()));
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateHealthAnalysisCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(
            int id,
            UpdateHealthAnalysisCommand command)
        {
            command.Id = id;
            return Ok(await _mediator.Send(command));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _mediator.Send(
                new DeleteHealthAnalysisCommand
                {
                    Id = id
                }));
        }
    }
}