namespace FitnessAI.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string HoTen { get; set; } = string.Empty;

        public int Tuoi { get; set; }

        public string GioiTinh { get; set; } = string.Empty;

        public double ChieuCao { get; set; }

        public double CanNang { get; set; }

        public double BMI { get; set; }

        public string MucTieu { get; set; } = string.Empty;
    }
}