namespace FitnessAI.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }

        // =========================
        // Thông tin cá nhân
        // =========================

        public string HoTen { get; set; } = string.Empty;

        public int Tuoi { get; set; }

        public string GioiTinh { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        // Nên dùng PasswordHash thay vì Password
        public string PasswordHash { get; set; } = string.Empty;

        public string Role { get; set; } = "User";

        public string SoDienThoai { get; set; } = string.Empty;

        public string AvatarUrl { get; set; } = string.Empty;

        // =========================
        // Thông tin cơ thể
        // =========================

        public double ChieuCao { get; set; }

        public double CanNang { get; set; }

        public double BMI { get; set; }

        public double BMR { get; set; }

        public double TDEE { get; set; }

        public double BodyFat { get; set; }

        // =========================
        // Mục tiêu sức khỏe
        // =========================

        public string MucTieu { get; set; } = string.Empty;

        // Calories mục tiêu mỗi ngày
        public int CaloriesMucTieuHangNgay { get; set; }

        // Cân nặng mục tiêu
        public double CanNangMucTieu { get; set; }

        // =========================
        // Premium & trạng thái
        // =========================

        public bool IsPremium { get; set; }

        public bool IsActive { get; set; } = true;

        // =========================
        // Thời gian
        // =========================

        public DateTime NgayTao { get; set; }

        // =========================
        // Navigation Properties
        // =========================

        public ICollection<MealPlan>? MealPlans { get; set; }

        public ICollection<WorkoutPlan>? WorkoutPlans { get; set; }

        public ICollection<Progress>? Progresses { get; set; }

        public ICollection<Subscription>? Subscriptions { get; set; }

        public ICollection<AIRecommendation>? AIRecommendations { get; set; }

        public ICollection<WaterTracking>? WaterTrackings { get; set; }

        public ICollection<SleepTracking>? SleepTrackings { get; set; }

        public ICollection<HealthAnalysisEntity>? HealthAnalyticsEntities { get; set; }

        public ICollection<Notification>? Notifications { get; set; }

        public ICollection<Payment>? Payments { get; set; }
    }
}