using FitnessAI.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitnessAI.Application.Features.AIRecommendations.Commands.UpdateAIRecommendation
{
    public class UpdateAIRecommendationHandler
        : IRequestHandler<UpdateAIRecommendationCommand, bool>
    {
        private readonly IUserDbContext _context;

        public UpdateAIRecommendationHandler(IUserDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(
            UpdateAIRecommendationCommand request,
            CancellationToken cancellationToken)
        {
            var aiRecommendation = await _context.AIRecommendations
                .FirstOrDefaultAsync(x => x.Id == request.Id);

            if (aiRecommendation == null)
            {
                return false;
            }

            aiRecommendation.MucTieu = request.MucTieu;
            aiRecommendation.ThucDonDeXuat = request.ThucDonDeXuat;
            aiRecommendation.LichTapDeXuat = request.LichTapDeXuat;
            aiRecommendation.CaloriesHangNgay = request.CaloriesHangNgay;
            aiRecommendation.GhiChu = request.GhiChu;

            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}