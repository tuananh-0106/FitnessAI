using FitnessAI.Application.Features.Users.Command.CreateUser;
using FitnessAI.Application.Features.Users.Commands.DeleteUser;
using FitnessAI.Application.Features.Users.Commands.UpdateUser;
using FitnessAI.Application.Features.Users.Queries.GetAllUsers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FitnessAI.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _mediator.Send(
                new GetAllUsersQuery()));
        }

        // POST: api/Users
        [HttpPost]
        public async Task<IActionResult> Create(
            CreateUserCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        // PUT: api/Users/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(
            int id,
            UpdateUserCommand command)
        {
            command.Id = id;

            return Ok(await _mediator.Send(command));
        }

        // DELETE: api/Users/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _mediator.Send(
                new DeleteUserCommand(id)));
        }
    }
}