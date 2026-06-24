namespace FitnessAI.Domain.Entities
{
    public class Progress
    {
        public int Id { get; set; }

        public double CanNang { get; set; }

        public double ChieuCao { get; set; }

        public double BMI { get; set; }

        public double MoCoThe { get; set; }

        public double KhoiLuongCo { get; set; }

        public int CaloriesDotChay { get; set; }

        public string GhiChu { get; set; } = string.Empty;

        public DateTime NgayCapNhat { get; set; }

        // Foreign Key
        public int UserId { get; set; }

        // Navigation Property
        public User? User { get; set; }
    }
}