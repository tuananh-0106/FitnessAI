using FitnessAI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitnessAI.Infrastructure.Configurations
{
    public class WorkoutPlanConfiguration
        : IEntityTypeConfiguration<WorkoutPlan>
    {
        public void Configure(
            EntityTypeBuilder<WorkoutPlan> builder)
        {
            builder.ToTable("WorkoutPlans");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.TenBaiTap)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(x => x.MucTieu)
                .HasMaxLength(100);

            builder.Property(x => x.CapDo)
                .HasMaxLength(50);

            builder.Property(x => x.MoTa)
                .HasMaxLength(500);

            builder.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}