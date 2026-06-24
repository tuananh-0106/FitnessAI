using FitnessAI.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Application.Features.Progress.Commands.DeleteProgress
{
    public class DeleteProgressCommandHandler
        : IRequestHandler<DeleteProgressCommand, bool>
    {
        private readonly IUserDbContext _context;

        public DeleteProgressCommandHandler(
            IUserDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(
            DeleteProgressCommand request,
            CancellationToken cancellationToken)
        {
            var progress = await _context.Progresses
                .FirstOrDefaultAsync(
                    x => x.Id == request.Id,
                    cancellationToken);

            if (progress == null)
            {
                return false;
            }

            _context.Progresses.Remove(progress);

            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}