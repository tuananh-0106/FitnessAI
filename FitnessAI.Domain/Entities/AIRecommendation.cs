namespace FitnessAI.Domain.Entities
{
    public class AIRecommendation
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string MucTieu { get; set; } = string.Empty;

        public string ThucDonDeXuat { get; set; } = string.Empty;

        public string LichTapDeXuat { get; set; } = string.Empty;

        public int CaloriesHangNgay { get; set; }

        public string GhiChu { get; set; } = string.Empty;

        public DateTime NgayTao { get; set; }

        // Navigation
        public User? User { get; set; }
    }
}