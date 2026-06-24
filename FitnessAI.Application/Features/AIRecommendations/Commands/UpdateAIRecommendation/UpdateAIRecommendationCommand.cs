using MediatR;

namespace FitnessAI.Application.Features.AIRecommendations.Commands.UpdateAIRecommendation
{
    public class UpdateAIRecommendationCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public string MucTieu { get; set; } = string.Empty;

        public string ThucDonDeXuat { get; set; } = string.Empty;

        public string LichTapDeXuat { get; set; } = string.Empty;

        public int CaloriesHangNgay { get; set; }

        public string GhiChu { get; set; } = string.Empty;
    }
}