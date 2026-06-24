using FitnessAI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitnessAI.Infrastructure.Configurations
{
    public class MealPlanConfiguration
        : IEntityTypeConfiguration<MealPlan>
    {
        public void Configure(
            EntityTypeBuilder<MealPlan> builder)
        {
            builder.ToTable("MealPlans");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.TenThucDon)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(x => x.MucTieu)
                .HasMaxLength(100);

            builder.Property(x => x.MoTa)
                .HasMaxLength(500);

            builder.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}