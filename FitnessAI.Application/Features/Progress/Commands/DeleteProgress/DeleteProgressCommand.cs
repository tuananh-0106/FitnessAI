using MediatR;

namespace FitnessAI.Application.Features.Progress.Commands.DeleteProgress
{
    public class DeleteProgressCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}