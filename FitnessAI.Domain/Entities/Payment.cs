using FitnessAI.Domain.Enums;

namespace FitnessAI.Domain.Entities
{
    public class Payment
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int SubscriptionId { get; set; }

        public decimal SoTien { get; set; }

        public string PhuongThucThanhToan { get; set; } = string.Empty;

        public string MaGiaoDich { get; set; } = string.Empty;
        
        public PaymentStatus TrangThai { get; set; } 

        public DateTime NgayThanhToan { get; set; }

        // Navigation
        public User? User { get; set; }

        public Subscription? Subscription { get; set; }
    }
}