using FitnessAI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitnessAI.Infrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.HoTen)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.GioiTinh)
                .HasMaxLength(20);

            builder.Property(x => x.MucTieu)
                .HasMaxLength(200);
        }
    }
}