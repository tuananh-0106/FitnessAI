using FitnessAI.Application.Features.Subscriptions.Queries.GetAllSubscription;
using FitnessAI.Application.Features.Users.Commands.DeleteUser;
using FitnessAI.Application.Features.Users.Queries.GetAllUsers;
using FitnessAI.Application.Features.Users.Queries.GetUserById;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitnessAI.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin")]
    public class AdminController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AdminController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // Danh sách User
        [HttpGet("users")]
        public async Task<IActionResult> GetUsers()
        {
            return Ok(await _mediator.Send(new GetAllUsersQuery()));
        }

        // Chi tiết User
        [HttpGet("users/{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            return Ok(await _mediator.Send(new GetUserByIdQuery(id)));
        }

        // Xóa User
        [HttpDelete("users/{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            return Ok(await _mediator.Send(new DeleteUserCommand(id)));
        }
        // Danh sách Subscription
        [HttpGet("subscriptions")]
        public async Task<IActionResult> GetSubscriptions()
        {
            return Ok(await _mediator.Send(new GetAllSubscriptionQuery()));
        } 
    }
}