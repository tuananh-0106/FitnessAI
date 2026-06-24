using FitnessAI.Application.Common.Interfaces;
using FitnessAI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace FitnessAI.Application.Features.Foods.Queries.GetAllFoods
{
    public class GetAllFoodsHandler
        : IRequestHandler<GetAllFoodsQuery, List<Food>>
    {
        private readonly IUserDbContext _context;

        public GetAllFoodsHandler(IUserDbContext context)
        {
            _context = context;
        }

        public async Task<List<Food>> Handle(
            GetAllFoodsQuery request,
            CancellationToken cancellationToken)
        {
            return await _context.Foods
                .ToListAsync(cancellationToken);
        }
    }
}