namespace FitnessAI.Domain.Entities
{
    public class Notification
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string TieuDe { get; set; } = string.Empty;

        public string NoiDung { get; set; } = string.Empty;

        public bool DaDoc { get; set; }

        public DateTime NgayTao { get; set; }

        // Navigation
        public User? User { get; set; }
    }
}