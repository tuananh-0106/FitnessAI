using MediatR;

namespace FitnessAI.Application.Features.Foods.Commands.UpdateFood
{
    public class UpdateFoodCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public string TenMonAn { get; set; } = string.Empty;

        public double Calories { get; set; }

        public double Protein { get; set; }

        public double Carbs { get; set; }

        public double Fat { get; set; }

        public double ChatXo { get; set; }

        public string DanhMuc { get; set; } = string.Empty;

        public string HinhAnhUrl { get; set; } = string.Empty;
    }
}