namespace FitnessAI.Domain.Entities
{
    public class HealthAnalysisEntity
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public double ChieuCao { get; set; }

        public double CanNang { get; set; }

        public double BMI { get; set; }

        public double BMR { get; set; }

        public double TDEE { get; set; }

        public double BodyFat { get; set; }

        public string TinhTrangSucKhoe { get; set; } = string.Empty;

        public DateTime NgayGhiNhan { get; set; }

        // Navigation
        public User? User { get; set; }
    }
}