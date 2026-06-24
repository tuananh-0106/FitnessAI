using FitnessAI.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace FitnessAI.Application.Features.Foods.Commands.DeleteFood
{
    public class DeleteFoodHandler
        : IRequestHandler<DeleteFoodCommand, bool>
    {
        private readonly IUserDbContext _context;

        public DeleteFoodHandler(IUserDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(
            DeleteFoodCommand request,
            CancellationToken cancellationToken)
        {
            var food = await _context.Foods
                .FirstOrDefaultAsync(x => x.Id == request.Id);

            if (food == null)
            {
                return false;
            }

            _context.Foods.Remove(food);

            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}