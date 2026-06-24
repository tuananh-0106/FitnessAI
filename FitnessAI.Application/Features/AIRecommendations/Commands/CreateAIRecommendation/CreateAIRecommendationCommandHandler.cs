using FitnessAI.Application.Common.Interfaces;
using FitnessAI.Domain.Entities;
using MediatR;

namespace FitnessAI.Application.Features.AIRecommendations.Commands.CreateAIRecommendation
{
    public class CreateAIRecommendationCommandHandler
        : IRequestHandler<CreateAIRecommendationCommand, int>
    {
        private readonly IUserDbContext _context;

        public CreateAIRecommendationCommandHandler(IUserDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(
            CreateAIRecommendationCommand request,
            CancellationToken cancellationToken)
        {
            var ai = new AIRecommendation
            {
                UserId = request.UserId,
                MucTieu = request.MucTieu,
                ThucDonDeXuat = request.ThucDonDeXuat,
                LichTapDeXuat = request.LichTapDeXuat,
                CaloriesHangNgay = request.CaloriesHangNgay,
                GhiChu = request.GhiChu,
                NgayTao = DateTime.Now
            };

            _context.AIRecommendations.Add(ai);
            await _context.SaveChangesAsync(cancellationToken);

            return ai.Id;
        }
    }
}