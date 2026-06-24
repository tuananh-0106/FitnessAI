namespace FitnessAI.Domain.Entities
{
    public class Subscription
    {
        public int Id { get; set; }

        public string TenGoi { get; set; } = string.Empty;

        public decimal GiaTien { get; set; }

        public int ThoiHanNgay { get; set; }

        public DateTime NgayBatDau { get; set; }

        public DateTime NgayKetThuc { get; set; }

        public bool TrangThai { get; set; }

        // Foreign Key
        public int UserId { get; set; }

        // Navigation Property
        public User? User { get; set; }
    }
}