using FitnessAI.Application.Common.Interfaces;
using FitnessAI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Application.Features.Foods.Queries.GetFoodById
{
    public class GetFoodByIdHandler
        : IRequestHandler<GetFoodByIdQuery, Food?>
    {
        private readonly IUserDbContext _context;

        public GetFoodByIdHandler(IUserDbContext context)
        {
            _context = context;
        }

        public async Task<Food?> Handle(
            GetFoodByIdQuery request,
            CancellationToken cancellationToken)
        {
            return await _context.Foods
                .FirstOrDefaultAsync(
                    x => x.Id == request.Id,
                    cancellationToken);
        }
    }
}