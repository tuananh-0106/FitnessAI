using FitnessAI.Application.Common.Interfaces;
using FitnessAI.Domain.Entities;
using MediatR;

namespace FitnessAI.Application.Features.Foods.Commands.CreateFood
{
    public class CreateFoodHandler
        : IRequestHandler<CreateFoodCommand, int>
    {
        private readonly IUserDbContext _context;

        public CreateFoodHandler(IUserDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(
            CreateFoodCommand request,
            CancellationToken cancellationToken)
        {
            var food = new Food
            {
                TenMonAn = request.TenMonAn,
                Calories = request.Calories,
                Protein = request.Protein,
                Carbs = request.Carbs,
                Fat = request.Fat,
                ChatXo = request.ChatXo,
                DanhMuc = request.DanhMuc,
                HinhAnhUrl = request.HinhAnhUrl,
                IsActive = true
            };

            _context.Foods.Add(food);

            await _context.SaveChangesAsync(cancellationToken);

            return food.Id;
        }
    }
}