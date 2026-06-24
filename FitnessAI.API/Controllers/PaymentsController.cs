using FitnessAI.Application.Features.Payments.Commands.CreatePayment;
using FitnessAI.Application.Features.Payments.Commands.ConfirmPayment;
using FitnessAI.Application.Features.Payments.Commands.CancelPayment;
using FitnessAI.Application.Features.Payments.Queries.GetAllPayments;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FitnessAI.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PaymentsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _mediator.Send(new GetAllPaymentsQuery()));
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreatePaymentCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("confirm/{id}")]
        public async Task<IActionResult> Confirm(int id)
        {
            return Ok(await _mediator.Send(
                new ConfirmPaymentCommand
                {
                    Id = id
                }));
        }

        [HttpPut("cancel/{id}")]
        public async Task<IActionResult> Cancel(int id)
        {
            return Ok(await _mediator.Send(
                new CancelPaymentCommand
                {
                    Id = id
                }));
        }
    }
}