using MediatR;

namespace FitnessAI.Application.Features.AIRecommendations.Commands.CreateAIRecommendation
{
    public class CreateAIRecommendationCommand : IRequest<int>
    {
        public int UserId { get; set; }

        public string MucTieu { get; set; } = string.Empty;

        public string ThucDonDeXuat { get; set; } = string.Empty;

        public string LichTapDeXuat { get; set; } = string.Empty;

        public int CaloriesHangNgay { get; set; }

        public string GhiChu { get; set; } = string.Empty;
    }
}