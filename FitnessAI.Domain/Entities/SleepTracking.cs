namespace FitnessAI.Domain.Entities
{
    public class SleepTracking
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public DateTime GioBatDauNgu { get; set; }

        public DateTime GioThucDay { get; set; }

        public double TongSoGioNgu { get; set; }

        public string ChatLuongNgu { get; set; } = string.Empty;

        public string GhiChu { get; set; } = string.Empty;

        // Navigation
        public User? User { get; set; }
    }
}