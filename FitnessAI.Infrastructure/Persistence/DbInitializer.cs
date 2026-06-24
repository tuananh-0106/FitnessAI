using FitnessAI.Domain.Entities;

namespace FitnessAI.Infrastructure.Persistence
{
    public static class DbInitializer
    {
        public static async Task SeedAsync(ApplicationDbContext context)
        {
            if (!context.Users.Any())
            {
                var users = new List<User>
                {
                    new User
                    {
                        HoTen = "Nguyen Van A",
                        Tuoi = 22,
                        GioiTinh = "Nam",
                        ChieuCao = 175,
                        CanNang = 70,
                        BMI = 22.9,
                        MucTieu = "Tang co",
                        NgayTao = DateTime.Now
                    },

                    new User
                    {
                        HoTen = "Tran Thi B",
                        Tuoi = 24,
                        GioiTinh = "Nu",
                        ChieuCao = 160,
                        CanNang = 50,
                        BMI = 19.5,
                        MucTieu = "Giam can",
                        NgayTao = DateTime.Now
                    }
                };

                await context.Users.AddRangeAsync(users);

                await context.SaveChangesAsync();
            }
        }
    }
}