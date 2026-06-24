namespace FitnessAI.Domain.Entities
{
    public class MealPlan
    {
        public int Id { get; set; }

        public string TenThucDon { get; set; } = string.Empty;

        public string MucTieu { get; set; } = string.Empty;

        public int Calories { get; set; }

        public int Protein { get; set; }

        public int Carbs { get; set; }

        public int Fat { get; set; }

        public string DanhSachMonAn { get; set; } = string.Empty;

        public string MoTa { get; set; } = string.Empty;

        public DateTime NgayTao { get; set; }

        // Foreign Key
        public int UserId { get; set; }

        // Navigation Property
        public User? User { get; set; } 
        public string? ThoiGian { get; set; }
    }
}