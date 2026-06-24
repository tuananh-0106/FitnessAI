namespace FitnessAI.Domain.Entities
{
    public class WaterTracking
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public double LuongNuocML { get; set; }

        public DateTime ThoiGianUong { get; set; }

        // Navigation
        public User? User { get; set; }
    }
}