using FitnessAI.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace FitnessAI.Application.Features.Foods.Commands.UpdateFood
{
    public class UpdateFoodHandler
        : IRequestHandler<UpdateFoodCommand, bool>
    {
        private readonly IUserDbContext _context;

        public UpdateFoodHandler(IUserDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(
            UpdateFoodCommand request,
            CancellationToken cancellationToken)
        {
            var food = await _context.Foods
                .FirstOrDefaultAsync(x => x.Id == request.Id);

            if (food == null)
            {
                return false;
            }

            food.TenMonAn = request.TenMonAn;
            food.Calories = request.Calories;
            food.Protein = request.Protein;
            food.Carbs = request.Carbs;
            food.Fat = request.Fat;
            food.ChatXo = request.ChatXo;
            food.DanhMuc = request.DanhMuc;
            food.HinhAnhUrl = request.HinhAnhUrl;

            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}