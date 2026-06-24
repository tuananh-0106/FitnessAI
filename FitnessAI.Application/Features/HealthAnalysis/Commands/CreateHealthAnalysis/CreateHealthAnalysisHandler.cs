using FitnessAI.Application.Common.Interfaces;
using FitnessAI.Domain.Entities;
using MediatR;


namespace FitnessAI.Application.Features.HealthAnalysis.Commands.CreateHealthAnalytics
{
    public class CreateHealthAnalysisHandler
        : IRequestHandler<CreateHealthAnalysisCommand, int>
    {
        private readonly IUserDbContext _context;

        public CreateHealthAnalysisHandler(IUserDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(
            CreateHealthAnalysisCommand request,
            CancellationToken cancellationToken)
        {
            // BMI
            var bmi = request.CanNang /
                     ((request.ChieuCao / 100) *
                     (request.ChieuCao / 100));

            // BMR
            double bmr = 0;

            var user = await _context.Users.FindAsync(request.UserId);

            if (user != null)
            {
                if (user.GioiTinh.ToLower() == "nam")
                {
                    bmr = 10 * request.CanNang
                        + 6.25 * request.ChieuCao
                        - 5 * user.Tuoi
                        + 5;
                }
                else
                {
                    bmr = 10 * request.CanNang
                        + 6.25 * request.ChieuCao
                        - 5 * user.Tuoi
                        - 161;
                }
            }

            // TDEE
            var tdee = bmr * 1.55;

            // Health Status
            string tinhTrang = "";

            if (bmi < 18.5)
            {
                tinhTrang = "Thiếu cân";
            }
            else if (bmi < 25)
            {
                tinhTrang = "Bình thường";
            }
            else if (bmi < 30)
            {
                tinhTrang = "Thừa cân";
            }
            else
            {
                tinhTrang = "Béo phì";
            }

            var health = new HealthAnalysisEntity
            {
                UserId = request.UserId,
                ChieuCao = request.ChieuCao,
                CanNang = request.CanNang,
                BMI = bmi,
                BMR = bmr,
                TDEE = tdee,
                BodyFat = request.BodyFat,
                TinhTrangSucKhoe = tinhTrang,
                NgayGhiNhan = DateTime.Now
            };

            _context.HealthAnalysisEntity.Add(health);

            await _context.SaveChangesAsync(cancellationToken);

            return health.Id;
        }
    }
}