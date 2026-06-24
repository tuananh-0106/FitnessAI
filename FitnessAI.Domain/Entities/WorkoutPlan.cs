namespace FitnessAI.Domain.Entities
{
    public class WorkoutPlan
    {
        public int Id { get; set; }

        public string TenBaiTap { get; set; } = string.Empty;

        public string MucTieu { get; set; } = string.Empty;

        public string CapDo { get; set; } = string.Empty;

        public string DanhSachBaiTap { get; set; } = string.Empty;

        public int SoNgayTap { get; set; }

        public int CaloriesDotChay { get; set; }

        public string MoTa { get; set; } = string.Empty;

        public DateTime NgayTao { get; set; }

        // Foreign Key
        public int UserId { get; set; }

        // Navigation Property
        public User? User { get; set; }
        public int SoNgay { get; set; }
    }
}