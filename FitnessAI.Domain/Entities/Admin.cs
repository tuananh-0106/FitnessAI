namespace FitnessAI.Domain.Entities
{
    public class Admin
    {
        public int Id { get; set; }

        public string HoTen { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        public string VaiTro { get; set; } = "Admin";

        public bool IsActive { get; set; } = true;

        public DateTime NgayTao { get; set; }
    }
}